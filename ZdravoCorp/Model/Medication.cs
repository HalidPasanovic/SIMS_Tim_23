// File:    Medication.cs
// Author:  halid
// Created: Thursday, 14 April 2022 21:58:54
// Purpose: Definition of Class Medication

using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Medication : Serializable
    {
        private int id;
        private int count;

        private MedicationType medicationType;
        private int v;

        /// <summary>
        /// Property for MedicationType
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public MedicationType MedicationType
        {
            get
            {
                return medicationType;
            }
            set
            {
                this.medicationType = value;
            }
        }
        public int Id { get => id; set => id = value; }
        public int Count { get => count; set => count = value; }

        public string Name
        {
            get => medicationType.Name; set => medicationType.Name = value;
        }
        public string Manufacturer
        {
            get => medicationType.Manufacturer; set => medicationType.Manufacturer = value;
        }
        public string Description
        {
            get => medicationType.Description; set => medicationType.Description = value;
        }

        public Medication(int id, int count)
        {
            this.medicationType = new MedicationType(id);
            this.count = count;
        }

        public Medication()
        {
        }

        public Medication(int count, MedicationType medicationType)
        {
            this.count = count;
            this.medicationType = medicationType;
        }

        public Medication(int vid)
        {
            this.id = id;
        }

        public void FromCSV(string[] values)
        {
            int i = 0;
            id = int.Parse(values[i++]);
            count = int.Parse(values[i++]);
            values = values.Skip(i).ToArray();
            medicationType = new MedicationType();
            medicationType.FromCSV(values);
        }

        public List<String> ToCSV()
        {
            List<String> result = new List<String>();
            result.Add(id.ToString());
            result.Add(count.ToString());
            result.AddRange(medicationType.ToCSV());
            return result;
        }
    }
}