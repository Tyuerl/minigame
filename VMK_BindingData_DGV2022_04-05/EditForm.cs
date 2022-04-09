namespace VMK_BindingData_DGV2022_04_05;

public partial class EditForm : Form
{
    // Свойство для хранения информации об объекте
    public TableRowData UserData { get; }

    // Резервная копия данных объекта, полученная из основной формы
    private readonly TableRowData _userBackupData;
    
    // Информация об исключении при редактировании данных (при наличии ошибок)
    private BindingException? _bindingException;
    
    public EditForm(TableRowData? ud = null)
    {
        InitializeComponent();
        
        // Результат работы диалога по умолчанию (необходимо для закрытия окна по [x])
        DialogResult = DialogResult.Cancel;
        
        // Если переданые данные из главной формы...
        if (ud is not null)
            UserData = ud; // сохраняем их в свойстве с данными
        else UserData = new TableRowData(); // ... иначе - создаем новое свойство с данными
        
        // Делаем резервную копию исходно переданных данных на случай отмены радактирования
        _userBackupData = UserData.Copy();
        
        // Производим связывание данных между графическими элементами и свойством с хранимой информацией об объекте
        numericUpDown1.DataBindings.Add("Value", UserData, "Id");
        textBox1.DataBindings.Add("Text", UserData, "Value1");
        var v2Binding = textBox2.DataBindings.Add("Text", UserData, "Value2");
        // Включаем поддержку форматирования ввода
        // (обеспечивает контроль ошибок при вводе данных)
        v2Binding.FormattingEnabled = true; // !!!!
        // Назначаем метод, который будет вызываться для анализа
        // введенных в проверяемое поле данных
        v2Binding.BindingComplete += V2BindingComplete;
        checkBox1.DataBindings.Add("Checked", UserData, "IsChecked");
    }

    private void V2BindingComplete(object? sender, BindingCompleteEventArgs e)
    {
        // Вызывается при изменении данных
        if (e.BindingCompleteState != BindingCompleteState.Success)
        {
            // Если изменения прошли с ошибкой (сработало исключение в TableRowData)
            textBox2.BackColor = Color.OrangeRed;
            textBox2.Focus();
        }
        
        // Сохраняем информацию о произошедшем исключении в поле класса
        _bindingException = e.Exception as BindingException;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Кнопка "Сохранить"

        //Если было исключение при заполнении значений
        if (_bindingException is not null)
        {
            // Выводим сообщение об ошибке
            MessageBox.Show(
                _bindingException.Message,
                _bindingException.ErrorField,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            
            // и не даем окну закрыться. 
            return;
        }

        // Сюда попадем только если ошибок нет и данные можно сохранять
        // Установим результат работы с диалоговым окном
        DialogResult = DialogResult.OK;
        
        // И закроем окно.
        Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        // Кнопка "Отменить".

        // Восстанавливаем данные об объекте из резервной копии, чтобы
        // отменить возможные изменения, которые успел сделать пользователь
        _userBackupData.CopyTo(UserData);
        Close();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        // Если пользователь редактирует неверное поле, убираем подсветку,
        // сигнализирующую об ошибке. 
        textBox2.BackColor = Color.White;
    }
}
