using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classified
{

    class Classfied
    {
        private string category;
        private string description;
        private int cost;

        public Classfied(string category, string description, int cost)
        {
            Category = category;
            Description = description;
            Cost = cost;
        }

        public string Category
        {
            set
            {
                category = value;
            }

            get
            {
                return category;
            }
        }

        public string Description
        {
            set
            {
                description = value;
            }

            get
            {
                return description;
            }
        }

        public int Cost
        {
            set
            {
                cost = value;
            }

            get
            {
                return cost;
            }
        }

        public string GetInfo()
            {
                string info;
                info = string.Format($"\nCategory : {Category} \ndescription : {Description} \ncost : {Cost}");
                return info;


            }
    }
            }
