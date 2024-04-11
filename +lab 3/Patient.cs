using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Threading;
using Newtonsoft.Json;

namespace PatientManagement
{
    public class Patient
    {
        public static List<Patient> patientList = JsonRead();

        [JsonProperty]
        private BigInteger oib;

        [JsonProperty]
        private BigInteger mbo;

        [JsonProperty]
        private string fullName;

        [JsonProperty]
        private DateTime dob;

        [JsonProperty]
        private char sex;

        [JsonProperty]
        private string diagnosis;

        public Patient(BigInteger oib, BigInteger mbo, string fullName, DateTime dob, char sex, string diagnosis)
        {
            this.oib = oib;
            this.mbo = mbo;
            this.fullName = fullName;
            this.dob = dob;
            this.sex = sex;
            this.diagnosis = diagnosis;
        }

        public static bool IsValidOib(BigInteger oib)
        {
            string oibString = oib.ToString();
            return oibString.Length == 11;
        }

        public static bool IsValidMbo(BigInteger mbo)
        {
            string mboString = mbo.ToString();
            return mboString.Length == 9;
        }

        public void Info()
        {
            Console.WriteLine("OIB: " + oib);
            Console.WriteLine("MBO: " + mbo);
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Date of birth: " + dob);
            Console.WriteLine("Sex: " + sex);
            Console.WriteLine("Diagnosis: " + diagnosis);
        }

        public BigInteger GetOib()
        {
            return oib;
        }

        public void SetOib(BigInteger value)
        {
            oib = value;
        }

        public BigInteger GetMbo()
        {
            return mbo;
        }

        public void SetMbo(BigInteger value)
        {
            mbo = value;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetFullName(string value)
        {
            fullName = value;
        }

        public DateTime GetDob()
        {
            return dob;
        }

        public void SetDob(DateTime value)
        {
            dob = value;
        }

        public char GetSex()
        {
            return sex;
        }

        public void SetSex(char value)
        {
            sex = value;
        }

        public string GetDiagnosis()
        {
            return diagnosis;
        }

        public void SetDiagnosis(string value)
        {
            diagnosis = value;
        }

        public static void JsonWrite(List<Patient> patientList)
        {
            string json = JsonConvert.SerializeObject(patientList, Formatting.Indented);
            using (StreamWriter streamWriter = new StreamWriter("patients.json"))
            {
                streamWriter.Write(json);
            }
        }

        public static List<Patient> JsonRead()
        {
            List<Patient> patientList = new List<Patient> { };
            try
            {
                string json = File.ReadAllText("patients.json");
                patientList = JsonConvert.DeserializeObject<List<Patient>>(json);

            }
            catch (FileNotFoundException fileException)
            {
                Console.WriteLine("File \"patients.json\" not found. Creating a new file...");
                Thread.Sleep(1000);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return patientList;
        }

        public static Patient FindPatient(BigInteger oib)
        {
            Patient search = patientList.Find(patient => patient.GetOib() == oib);
            return (search != null) ? search : null;
        }
    }
}
