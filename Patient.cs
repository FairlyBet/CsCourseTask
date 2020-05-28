using System;
using System.IO;

namespace CsCourseTask
{
    class Patient
    {
        String fullname;
        String workType;
        String recordCardNumber;
        UInt32 serviceCost;
        UInt32 debtAmount = 0;
        Boolean isPayed; 
        public string Fullname { get => fullname; }
        public bool IsPayed { get => isPayed; }
        public uint DebtAmount { get => debtAmount; set => debtAmount = value; }
        public string WorkType { get => workType; }
        public string RecordCardNumber { get => recordCardNumber; }
        public uint ServiceCost { get => serviceCost; }

        public Patient() { }

        public Patient(String fullname, String workType, String recordCardNumber,
            UInt32 serviceCost, Boolean isPayed)
        {
            this.fullname = fullname;
            this.workType = workType;
            this.recordCardNumber = recordCardNumber;
            this.serviceCost = serviceCost;
            if (!isPayed)
                this.debtAmount = serviceCost;
            this.isPayed = isPayed;
        }

        public void Save(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(fullname);
            binaryWriter.Write(workType);
            binaryWriter.Write(recordCardNumber);
            binaryWriter.Write(serviceCost);
          //  binaryWriter.Write(debtAmount);
            binaryWriter.Write(isPayed);
        }

        public void Load(BinaryReader binaryReader)
        {
            fullname = binaryReader.ReadString();
            workType = binaryReader.ReadString();
            recordCardNumber = binaryReader.ReadString();
            serviceCost = binaryReader.ReadUInt32();
           // debtAmount = binaryReader.ReadUInt32();
            isPayed = binaryReader.ReadBoolean();
            if (isPayed == false)
                debtAmount = serviceCost;
        }

        public override string ToString()
        {
            return $"{fullname}\nНомер учетной карточки: {recordCardNumber}" +
                $"\nУслуга: {workType}\nСтоимость: {serviceCost}₴ ({(isPayed ? "Уплачено" : "Неуплачено")})" +
                $"\nСумма задолженности: {debtAmount}₴\n\n";
        }
    }
}