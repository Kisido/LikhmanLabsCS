using System.Reflection;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Lab4.Techniques;
using System.Linq;
using System.Drawing;

namespace Lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Assembly assembly;
        IEnumerable<Type> types;
        Type currentType;
        object currentObject;
        MethodInfo currentMethod;
        object[] methodParameters;

        private void MainForm_Load(object sender, EventArgs e)
        {
            assembly = Assembly.Load("Lab4.Techniques");
            types = assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("ITechnique") != null);
            ClassesComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }

        private void ClassesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnterParametersButton.Enabled = false;
            ExecuteMethodButton.Enabled = false;
            MethodParametersListBox.Items.Clear();
            ObjectPropertiesListBox.Items.Clear();
            MethodsComboBox.Items.Clear();

            currentType = types.First(type => type.Name == ClassesComboBox.SelectedItem.ToString());
            currentObject = null;

            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            MethodsComboBox.Items.AddRange(currentType.GetMethods().Where(method => !objectMethods.Contains(method.Name)
                && !method.Name.Contains("get_") && !method.Name.Contains("set_")).Select(method => method.Name).ToArray());

            MethodsComboBox.Enabled = false;
            CreateButton.Enabled = true;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ObjectPropertiesListBox.Items.Clear();
            MethodsComboBox.Enabled = true;
            ExecuteMethodButton.Enabled = false;
            EnterParametersButton.Enabled = false;

            MessageBox.Show("Введите объект класса " + currentType.Name);
            object newObject = Activator.CreateInstance(currentType);

            Form addForm = new Form();
            addForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            addForm.MaximizeBox = false;
            addForm.MinimizeBox = false;
            addForm.ClientSize = new Size(350, 200);

            int coordinate = 0;
            foreach (PropertyInfo info in newObject.GetType().GetProperties())
            {
                Label label = new Label { Top = coordinate, Left = 0, Width = addForm.ClientSize.Width / 2, Height = 20 };
                label.Text = info.Name;

                TextBox textBox = new TextBox { Top = coordinate, Left = label.Width, Width = label.Width, Height = 20 };
                textBox.Text = "1";

                addForm.Controls.Add(label);
                addForm.Controls.Add(textBox);
                coordinate += label.Height + 5;
            }

            addForm.Controls.Add(new Button() { Top = 150, Left = 130, Width = 100, Height = 50, Text = "Подтвердить" });
            addForm.Controls[addForm.Controls.Count - 1].Click += new EventHandler((object sender2, EventArgs e2) => { addForm.DialogResult = DialogResult.OK; addForm.Close(); });

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                PropertyInfo[] properties = newObject.GetType().GetProperties();
                for (int i = 1, j = 0; i < addForm.Controls.Count; i+=2, j++)
                {
                    string value = addForm.Controls[i].Text;
                    try
                    {
                        if (value.Length != 0)
                        {
                            if (properties[j].PropertyType.Name == "Int32")
                            {
                                properties[j].SetValue(newObject, Int32.Parse(value));
                            }
                            else
                            {
                                properties[j].SetValue(newObject, value);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введён неверный параметр.");
                    }
                }
            }

            currentObject = newObject;
            foreach (PropertyInfo info in currentType.GetProperties())
            {
                ObjectPropertiesListBox.Items.Add(info.Name + ": " + info.GetValue(currentObject));
            }
        }

        private void MethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMethod = currentType.GetMethods().First(method => method.Name == MethodsComboBox.SelectedItem.ToString());
            methodParameters = null;

            ExecuteMethodButton.Enabled = false;

            if (currentMethod.GetParameters().Length == 0)
            {
                EnterParametersButton.Enabled = false;
                ExecuteMethodButton.Enabled = currentObject != null;
            }
            else
            {
                EnterParametersButton.Enabled = true;
                ExecuteMethodButton.Enabled = false;
            }

            MethodParametersListBox.Items.Clear();
            foreach (ParameterInfo info in currentMethod.GetParameters())
            {
                MethodParametersListBox.Items.Add(info.Name);
            }
        }

        private void EnterParametersButton_Click(object sender, EventArgs e)
        {
            if (MethodParametersListBox.SelectedIndex != -1)
            {
                MethodParametersListBox.Items.Clear();
                if (currentMethod.GetParameters().Length != 0)
                {
                    Form enterParamsForm = new Form();
                    enterParamsForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    enterParamsForm.MaximizeBox = false;
                    enterParamsForm.MinimizeBox = false;
                    enterParamsForm.ClientSize = new Size(300, 100);

                    int coordinate = 0;
                    foreach (ParameterInfo info in currentMethod.GetParameters())
                    {
                        Label label = new Label { Top = coordinate, Left = 0, Width = enterParamsForm.ClientSize.Width / 2, Height = 20 };
                        label.Text = info.ToString();

                        TextBox textBox = new TextBox { Top = coordinate, Left = label.Width, Width = label.Width, Height = 20 };
                        textBox.Text = "1";

                        enterParamsForm.Controls.Add(label);
                        enterParamsForm.Controls.Add(textBox);
                        coordinate += label.Height + 5;
                    }

                    enterParamsForm.Controls.Add(new Button() { Top = 50, Left = 100, Width = 100, Height = 50, Text = "Подтвердить" });
                    enterParamsForm.Controls[enterParamsForm.Controls.Count - 1].Click += new EventHandler((object sender1, EventArgs e1) => { enterParamsForm.DialogResult = DialogResult.OK; enterParamsForm.Hide(); });
                    if (enterParamsForm.ShowDialog() == DialogResult.OK)
                    {
                        List<object> parameters = new List<object>();
                        for (int i = 1; i < enterParamsForm.Controls.Count - 1; i += 2)
                        {
                            try
                            {
                                string value = enterParamsForm.Controls[i].Text;
                                parameters.Add(int.Parse(value));
                                MethodParametersListBox.Items.Add(enterParamsForm.Controls[i - 1].Text + ": " + value);
                                ExecuteMethodButton.Enabled = true;
                            }
                            catch
                            {
                                MessageBox.Show("Параметр введён неверно.");
                                MethodParametersListBox.Items.Add(enterParamsForm.Controls[i - 1].Text);
                                ExecuteMethodButton.Enabled = false;
                            }
                        }
                        methodParameters = parameters.ToArray();
                    }
                }
                else
                {
                    methodParameters = null;
                }
            }
        }

        private void ExecuteMethodButton_Click(object sender, EventArgs e)
        {
            if (MethodParametersListBox.Text.Length == 0 || MethodParametersListBox.SelectedIndex != -1)
            {
                if (currentMethod.GetParameters().Length != 0 && methodParameters == null)
                {
                    MessageBox.Show("Сначала введите параметры.");
                }
                else
                {
                    if (currentMethod.ReturnType == typeof(void))
                    {
                        currentMethod.Invoke(currentObject, methodParameters);
                        MessageBox.Show("Метод выполнен.");
                    }
                    else
                    {
                        MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());
                    }

                    ObjectPropertiesListBox.Items.Clear();
                    foreach (PropertyInfo info in currentType.GetProperties())
                    {
                        ObjectPropertiesListBox.Items.Add(info.Name + ": " + info.GetValue(currentObject));
                    }
                }
            }
            else
            {
                MessageBox.Show("Создайте объект и выберите метод.");
            }
        }
    }
}
