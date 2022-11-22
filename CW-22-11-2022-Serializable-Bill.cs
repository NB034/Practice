using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    /*
    Разработать класс «Счет для оплаты». В классе предусмотреть следующие поля:
    ■ оплата за день;
    ■ количество дней;
    ■ штраф за один день задержки оплаты;
    ■ количество дней задержи оплаты;
    ■ сумма к оплате без штрафа (вычисляемое поле);
    ■ штраф (вычисляемое поле);
    ■ общая сумма к оплате (вычисляемое поле).
    В классе объявить статическое свойство типа bool,
    значение которого влияет на процесс форматирования
    объектов этого класса. Если значение этого свойства равно true, тогда сериализуются и десериализируются все
    поля, если false — вычисляемые поля не сериализуются.
    Разработать приложение, в котором необходимо продемонстрировать использование этого класса, результаты
    должны записываться и считываться из файла.
    */

    [Serializable]
    internal class Bill
    {
        static public bool _isSerialize = false;
        static private string _fileName = "SerializedBill.json";

        public uint PaymentPerDay { get; set; }
        public uint NumberOfDays { get; set; }
        public uint PenaltyForOneDayDelay { get; set; }
        public uint DaysWithDelay { get; set; }

        public uint BillWithoutPenalty { get; private set; }
        public uint Penalty { get; private set; }
        public uint OverallBill { get; private set; }

        public bool ShouldSerializeBillWithoutPenalty()
        {
            return Bill._isSerialize;
        }

        public bool ShouldSerializePenalty()
        {
            return Bill._isSerialize;
        }

        public bool ShouldSerializeOverallBill()
        {
            return Bill._isSerialize;
        }

        public void CalculateFields()
        {
            BillWithoutPenalty = NumberOfDays * PaymentPerDay;
            Penalty = DaysWithDelay * PenaltyForOneDayDelay;
            OverallBill = BillWithoutPenalty + Penalty;
        }

        public void Serialize()
        {
            DataContractJsonSerializer serizlizer = new DataContractJsonSerializer(typeof(Bill));
            using (var file = File.Create(_fileName))
            {
                serizlizer.WriteObject(file, this);
            }
        }

        public Bill Deserialize()
        {
            DataContractJsonSerializer serizlizer = new DataContractJsonSerializer(typeof(Bill));
            using (var file = File.Open(_fileName, FileMode.Open))
            {
                return serizlizer.ReadObject(file) as Bill;
            }
        }

        public void Print()
        {
            //Console.WriteLine($"{nameof(_isSerialize)} = {_isSerialize}");
            //Console.WriteLine($"{nameof(_fileName)} = {_fileName}");
            Console.WriteLine($"{nameof(PaymentPerDay)} = {PaymentPerDay}");
            Console.WriteLine($"{nameof(NumberOfDays)} = {NumberOfDays}");
            Console.WriteLine($"{nameof(PenaltyForOneDayDelay)} = {PenaltyForOneDayDelay}");
            Console.WriteLine($"{nameof(DaysWithDelay)} = {DaysWithDelay}");
            Console.WriteLine($"{nameof(BillWithoutPenalty)} = {BillWithoutPenalty}");
            Console.WriteLine($"{nameof(Penalty)} = {Penalty}");
            Console.WriteLine($"{nameof(OverallBill)} = {OverallBill}");
        }
    }
}
