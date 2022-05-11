﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoCorp.View.Core;

namespace ZdravoCorp.View.Manager.Model.Room
{
    public class RenovationActionModel : ObservableObject
    {
        private int id;
        private DateTime executionDate;
        private DateTime expirationDate;
        private string designationCode;
        private int id_room;
        private bool renovation;

        public RenovationActionModel()
        {
        }

        public RenovationActionModel(int id, DateTime executionDate, DateTime expirationDate, string designationCode, int id_room, bool renovation)
        {
            Id = id;
            ExecutionDate = executionDate;
            ExpirationDate = expirationDate;
            this.designationCode = designationCode;
            Id_room = id_room;
            Renovation = renovation;
        }

        public int Id
        {
            get => id;
            set
            {
                if (value != id)
                {
                    id= value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime ExecutionDate
        {
            get => executionDate;
            set
            {
                if (value != executionDate)
                {
                    executionDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime ExpirationDate
        {
            get => expirationDate;
            set
            {
                if (value != expirationDate)
                {
                    expirationDate = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Id_room
        {
            get => id_room;
            set
            {
                if (value != id_room)
                {
                    id_room = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Renovation
        {
            get => renovation;
            set
            {
                if (value != renovation)
                {
                    renovation = value;
                    OnPropertyChanged();
                }
            }
        }
        public string DesignationCode
        {
            get => designationCode;
            set
            {
                if (value != designationCode)
                {
                    designationCode = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
