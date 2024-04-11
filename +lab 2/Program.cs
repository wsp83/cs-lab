using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Threading;
using Newtonsoft.Json;


namespace BolnicaUpis
{
    public class Patient
    {
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patientList = JsonRead();

            char menuChoice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tMENU");
                Console.WriteLine("\nNew patient - press N");
                Console.WriteLine("\nDelete patient - press D");
                Console.WriteLine("\nModify patient - press M");
                Console.WriteLine("\nPatient list - press L");
                Console.WriteLine("\nPatient info - press I");

                menuChoice = Console.ReadKey(true).KeyChar;

                if (menuChoice == 'N' || menuChoice == 'n')
                    CreatePatient(patientList);
                else if (menuChoice == 'D' || menuChoice == 'd')
                    DeletePatient(patientList);
                else if (menuChoice == 'M' || menuChoice == 'm')
                    ModifyPatient(patientList);
                else if (menuChoice == 'L' || menuChoice == 'l')
                    GetAllPatients(patientList);
                else if (menuChoice == 'I' || menuChoice == 'i')
                    GetPatientInfo(patientList);
            }
        }

        static void CreatePatient(List<Patient> patientList)
        {
            BigInteger oib;
            BigInteger mbo;
            string fullName;
            DateTime dob;
            char sex;
            string diagnosis;

            Console.Clear();
            Console.WriteLine("\tPatient Creation");

            do
            {
                Console.Write("OIB: ");
                BigInteger.TryParse(Console.ReadLine(), out oib);
            } while (!Patient.IsValidOib(oib));
            
            do
            {
                Console.Write("MBO: ");
                BigInteger.TryParse(Console.ReadLine(), out mbo);
            } while (!Patient.IsValidMbo(mbo));

            Console.Write("Full name: ");
            fullName = Console.ReadLine();

            do
            {
                Console.Write("Date of birth (dd/mm/yyyy): ");
            } while (!DateTime.TryParseExact(Console.ReadLine(), "d/M/yyyy", null, DateTimeStyles.None, out dob));
            
            do
            {
                Console.Write("Sex (M/F): ");
                sex = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (sex != 'm' && sex != 'M' && sex != 'f' && sex != 'F');

            Console.Write("\nDiagnosis: ");
            diagnosis = Console.ReadLine();

            Patient patient = new Patient(oib, mbo, fullName, dob, sex, diagnosis);
            patientList.Add(patient);
            
            string json = JsonConvert.SerializeObject(patientList, Formatting.Indented);
            JsonWrite(json);

            Console.WriteLine("\nPatient created. Press any key to continue.");
            Console.ReadKey();
        }

        static void DeletePatient(List<Patient> patientList)
        {
            Console.Clear();
            BigInteger oib;
            Console.WriteLine("\tPatient Removal");
            do
            {
                Console.Write("Patient's OIB: ");
            }
            while (!BigInteger.TryParse(Console.ReadLine(), out oib));

            Patient search = patientList.Find(patient => patient.GetOib() == oib);
            if (search != null)
            {
                char menuChoice;
                Console.WriteLine();
                search.Info();
                do
                {
                    Console.WriteLine("\nAre you sure you want to delete this patient (y/n): ");
                    menuChoice = Console.ReadKey(true).KeyChar;
                } while (menuChoice != 'y' && menuChoice != 'Y' && menuChoice != 'n' && menuChoice != 'N');

                if (menuChoice == 'y' || menuChoice == 'Y')
                {
                    patientList.Remove(search);
                    search = null;
                    string json = JsonConvert.SerializeObject(patientList, Formatting.Indented);
                    JsonWrite(json);
                    Console.WriteLine("Deleted patient successfully. Press any key to continue.");
                }  
            }
            else
                Console.WriteLine("No such patient. Press any key to continue.");
            Console.ReadKey();
        }

        static void ModifyPatient(List<Patient> patientList)
        {
            Console.Clear();
            BigInteger oib;
            string diagnosis;
            Console.WriteLine("\tEdit Patient Diagnosis");
            do
            {
                Console.Write("Patient's OIB: ");
            }
            while (!BigInteger.TryParse(Console.ReadLine(), out oib));

            Patient search = patientList.Find(patient => patient.GetOib() == oib);
            if (search != null)
            {
                char menuChoice;
                Console.WriteLine();
                search.Info();

                Console.Write("\nNew diagnosis: ");
                diagnosis = Console.ReadLine();

                do
                {
                    Console.WriteLine("Do you want to save these changes? (y/n): ");
                    menuChoice = Console.ReadKey(true).KeyChar;
                } while (menuChoice != 'y' && menuChoice != 'Y' && menuChoice != 'n' && menuChoice != 'N');

                if (menuChoice == 'y' || menuChoice == 'Y')
                {
                    
                    search.SetDiagnosis(diagnosis);
                    string json = JsonConvert.SerializeObject(patientList, Formatting.Indented);
                    JsonWrite(json);
                    Console.WriteLine("Edited patient successfully. Press any key to continue.");
                }
            }
            else
                Console.WriteLine("No such patient. Press any key to continue.");
            Console.ReadKey();
        }

        static void GetAllPatients(List<Patient> patientList)
        {
            Console.Clear();
            Console.WriteLine("\tAll Patients\n");
            foreach (Patient patient in patientList)
            {
                patient.Info();
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void GetPatientInfo(List<Patient> patientList)
        {
            Console.Clear();
            BigInteger oib;
            Console.WriteLine("\tPatient Info");
            do
            {
                Console.Write("Patient's OIB: ");
            }
            while (!BigInteger.TryParse(Console.ReadLine(), out oib));

            Patient search = patientList.Find(patient => patient.GetOib() == oib);

            if (search != null)
            {
                Console.WriteLine();
                search.Info();
            }
            else
            {
                Console.WriteLine("No such patient.");
            }
            
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        static void JsonWrite(string json)
        {
            using (StreamWriter streamWriter = new StreamWriter("patients.json"))
            {
                streamWriter.Write(json);
            }
        }

        static List<Patient> JsonRead()
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
    }
}
