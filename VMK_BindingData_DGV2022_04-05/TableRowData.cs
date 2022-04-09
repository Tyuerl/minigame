using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VMK_BindingData_DGV2022_04_05.Annotations;

namespace VMK_BindingData_DGV2022_04_05
{
    public class TableRowData : INotifyPropertyChanged
    {
        private int _id;
        private string _value1;
        private string _value2;
        private bool _isChecked;

        [DisplayName("Номер")]
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        [DisplayName("Значение 1")]
        public string Value1
        {
            get => _value1;
            set
            {
                _value1 = value;
                OnPropertyChanged();
            }
        }

        [DisplayName("Значение 2")]
        public string Value2
        {
            get => _value2;
            set
            {
                if (value.Trim().Length == 0)
                    throw new BindingException("Значение 2", "Строка не должна быть пустой");
                _value2 = value;
                OnPropertyChanged();
            }
        }

        [DisplayName("Включено?")]
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged();
            }
        }

        public TableRowData(int id, string value1, string value2, bool isChecked)
        {
            Id = id;
            Value1 = value1;
            Value2 = value2;
            IsChecked = isChecked;
        }

        // Конструктор по умолчанию удобно использовать для создания новых значений
        public TableRowData()
        {
            // В нем необходимо предусмотреть, чтобы все свойства имели допустимые значения
            Value2 = "-";
        }

        // Метод для копирования объекта
        public TableRowData Copy() => new (Id, Value1, Value2, IsChecked);
        // Метод копирования данного объекта в другой, указанный в параметре
        // (можно использовать для восстановления данных из резервной копии
        // при отказе пользователя от сохранения сделанных изменений)
        public void CopyTo(TableRowData? trd)
        {
            if (trd is not null)
            {
                trd.Id = Id;
                trd.Value1 = Value1;
                trd.Value2 = Value2;
                trd.IsChecked = IsChecked;
            }
        }

        // Для автоматического обновления таблицы с данными
        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
