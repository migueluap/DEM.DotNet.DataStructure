using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.DataStructure.HashTableReHash
{
    class HashTable
    {
        Cell[] table;
        int quantity;
        int inserted;

        HashTable(int size)
        {
            int n = 0;
            quantity = size;
            inserted = 0;
            table = new Cell[quantity];

            for (n = 0; n < quantity; n++)
                table[n] = new Cell();
        }

        int HashFunction(int key, int nroTentative)
        {
            //Lineal probing
            int index = 0;
            //index = (key + nroTentative) % quantity;

            //Quadratic probing
            index = (key + nroTentative * nroTentative) % quantity;

            return index;
        }

        void Show()
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("{0} [{1},{2}]", i, table[i].Key, table[i].Value);
            }
        }

        void Insert(int key, string valuee)
        {
            int tentativeCount = 1;
            int index = 0;
            bool isBusy = false;

            while (isBusy == false)
            {
                index = HashFunction(key, tentativeCount);

                if (table[index].Estado == Estado.empty)
                {
                    isBusy = true;
                    table[index].Key = key;
                    table[index].Value = valuee;
                    table[index].Estado = Estado.busy;
                    inserted++;
                }
                else
                {
                    tentativeCount++;
                }
            }

            if (inserted >= ((double)quantity * 0.7))
            {
                Console.WriteLine("-- Needs do Rehash, {0} de {1} busy", inserted, quantity);
                ReHash();
            }
        }


        int CloseCousin(int valuee)
        {
            int cousin = 0;
            bool divide = false;
            int n = 0;

            while (cousin == 0)
            {
                divide = false;

                for (n = 2; n < valuee; n++)
                {
                    if (valuee % n == 0)
                    { 
                        divide = true;
                        valuee++;
                        break;
                    }
                }

                if (divide == false)
                    cousin = valuee;
            }
            return cousin;
        }

        public int ClimbStairs(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            int [] arr = new int[n + 1];
            
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n];
        }


        private void ReHash()
        {
            int newQuantity = CloseCousin(quantity * 2);
            int beforeQuantity = quantity;
            int n = 0;
            int key = 0;
            string valuee = "";

            int i = 0;
            int index = 0;


            //Pending implementation

            throw new NotImplementedException();
        }
    }
}
