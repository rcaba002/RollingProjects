﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUtilities
{
    public class StringList
    {
        private string[] innerList;

        public StringList()
        {
            innerList = new string[0];
        }

        public StringList(string[] passedInArray)
        {
            innerList = new string[passedInArray.Length];
            passedInArray.CopyTo(innerList, 0);
            Length = passedInArray.Length;
        }

        public int Length { get; set; }

        public string Get(int index)
        {
            return innerList[index];
        }

        public void Add(string item)
        {
            string[] temp = new string[innerList.Length + 1];
            innerList.CopyTo(temp, 0);
            temp[innerList.Length] = item;
            innerList = new string[temp.Length];
            temp.CopyTo(innerList, 0);
            Length = innerList.Length;
        }

        public void Clear()
        {
            innerList = new string[0];
            Length = innerList.Length;
        }

        public string[] GetArray()
        {
            string[] CopiedArray = new string[innerList.Length];
            innerList.CopyTo(CopiedArray, 0);
            return CopiedArray;
        }

        public void Remove(int indexToRemove)
        {
            string[] temp = new string[innerList.Length - 1];
            for (int i = 0; i < innerList.Length; i++)
            {
                if (i > indexToRemove)
                {
                    temp[i - 1] = innerList[i];
                }
                else
                {
                    temp[i] = innerList[i];
                }
            }

            innerList = temp;
        }
    }
}
