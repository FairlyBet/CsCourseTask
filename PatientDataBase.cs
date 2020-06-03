using System;
using System.Collections.Generic;
using System.IO;

namespace CsCourseTask
{
    class PatientDataBase
    {
        List<Patient> patients;
        String password;

        public List<Patient> Patients { get => patients; }

        public PatientDataBase() 
        {
            patients = new List<Patient>();
        }

        public PatientDataBase(String incomingPass)
        {
            password = incomingPass;
            patients = new List<Patient>();
        }

        public Boolean AddElement(String fullname, String workType, String recordCardNumber,
            UInt32 serviceCost, Boolean isPayed, Int32 numToEdit = -1)
        {
            if (fullname != "" && workType != "" && recordCardNumber != "")
            {
                if (numToEdit == -1)
                    patients.Add(new Patient(fullname, workType, recordCardNumber,
                    serviceCost, isPayed));
                else if (numToEdit < patients.Count && numToEdit >= 0)
                    patients[numToEdit] = new Patient(fullname, workType, recordCardNumber,
                        serviceCost, isPayed);
                else return false;

                return true;
            }
            else return false;
        }

        //public void DeleteElement(Int32 number)
        //{
        //    patients.RemoveAt(number);
        //}

        public string Search(String name)
        {
            string searchInf = "";
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].Fullname.ToLower().Contains(name.ToLower()))
                    searchInf += $"{i + 1}. {patients[i]}";
            }
            if (searchInf == "")
                searchInf = "По запросу ничего не найдено";
            return searchInf;
        }

        public String DebtSearch()
        {
            String inf = "";
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].DebtAmount > 0)
                    inf += $"{i + 1}. {patients[i]}";
            }
            if (inf == "")
                inf = "Должники отсутствуют";
            return inf;
        }

        public String WorkTypeSearch()
        {
            String inf = "", types = "";
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].DebtAmount > 0 && !types.Contains(patients[i].WorkType.GetHashCode().ToString()))
                {
                    types += $"{patients[i].WorkType.GetHashCode()} ";
                    inf += $"{patients[i].WorkType}:\n{i + 1}. {patients[i]}";
                    for (int k = i + 1; k < patients.Count; k++)
                    {
                        if (patients[k].DebtAmount > 0 && patients[i].WorkType == patients[k].WorkType)
                            inf += $"{k + 1}. {patients[k]}";
                    }
                    inf += "\n";
                }
            }
            if (inf == "")
                inf = "Должники отсутствуют";
            return inf;
        }

        public void RemoveNonDebtors()
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].DebtAmount == 0)
                {
                    patients.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Save(String path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);
            binaryWriter.Write(password);
            for (int i = 0; i < patients.Count; i++)
            {
                patients[i].Save(binaryWriter);
            }
            binaryWriter.Close();
            fileStream.Close();
        }

        public void Load(String path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            patients.Clear();
            password = binaryReader.ReadString();
            while (fileStream.Position < fileStream.Length)
            {
                Patient patient = new Patient();
                patient.Load(binaryReader);
                patients.Add(patient);
            }
            binaryReader.Close();
            fileStream.Close();
        }

        public static String ReadPass(String path)
        {
            String pass;
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            pass = binaryReader.ReadString();
            binaryReader.Close();
            fileStream.Close();
            return pass;
        }

        public override string ToString()
        {
            string allInf = "";
            for (int i = 0; i < patients.Count; i++)
            {
                allInf += $"{i + 1}. {patients[i]}";
            }
            if (allInf == "")
                allInf = "Список пуст...";
            return allInf;
        }
    }
}