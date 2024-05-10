using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskanje
{
    public class stevila
    {
        private List<int> stevilaList { get; set; }
        public int dolzina
        {
            get { return stevilaList.Count; }
        }
        public stevila()
        {
            stevilaList = new List<int>();
        }

        //DODAJ STEVILO
        public string Dodaj(int value)
        {
            stevilaList.Add(value);
            return stevilaList.ToString();
        }

        //PREVERI ALI VSEBUJA
        public bool Vsebuje(int value)
        {
            if (stevilaList.Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //loči z vejico
        public new string ToString()
        {
            return string.Join(", ", stevilaList);
        }

        //VSOTA VSEH STEVIL
        public string Vsota()
        {
            return stevilaList.Sum().ToString();
        }

        //MIN VREDNOST
        public string Min()
        {
            return stevilaList.Min().ToString();
        }

        //MAX VREDNOST
        public string Max()
        {
            return stevilaList.Max().ToString();
        }

        //POVPRAČJE STEVIL
        public string Povprecje()
        {
            return stevilaList.Average().ToString();
        }
        //če je urejen
        /*static bool urejeno(List<int> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }*/
        //vsebuje stevilo
        public bool VsebujeBinarno(int x)
        {
            int left = 0;
            int right = stevilaList.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (stevilaList[mid] == x)
                    return true;

                // Preverimo, če je leva polovica urejena
                if (stevilaList[left] <= stevilaList[mid])
                {
                    // Preverimo, ali je x v levi polovici
                    if (stevilaList[left] <= x && x < stevilaList[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                // Preverimo, če je desna polovica urejena
                else
                {
                    // Preverimo, ali je x v desni polovici
                    if (stevilaList[mid] < x && x <= stevilaList[right])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }

            return false;
        }
    
    //pregleda binarna stevilke
    /*static bool ime_binearno(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            string binary = Convert.ToString(number, 2);

            foreach (char c in binary)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
        }
        return true;
    }*/

    //UREJANJE BINARNO
    /* public List<int> Urejen_binarno()
     {
         return stevilaList.OrderBy(num => Convert.ToString(num, 2)).ToList();
     }*/

    //BINARNO ISKANJE
    /*public string BinarnoIskanje(int st)
        {
            int levo = 0;
            int desno = stevilaList.Count - 1;
            stevilaList.OrderBy(num => Convert.ToString(num, 2));

            while (levo <= desno)
            {
                int sredina = levo + (desno - levo) / 2;

                if (stevilaList[sredina] == st)
                {
                    return stevilaList.ToString();
                }

                if (stevilaList[sredina] < st)
                {
                    levo = sredina + 1;
                }
                else
                {
                    desno = sredina - 1;
                }
            }
            return stevilaList.ToString();
        }*/

        //UREDI Z ALGORITMOM
        public string Uredi()
        {
            //uredi z algoritmom navadno izbiranje
            int prvi;
            int min;
            int i, tmp;

            for (prvi = 0; prvi < 10; prvi++)
            {
                min = prvi;
                for (i = prvi + 1; i < 10; i++)
                    if (stevilaList[i] < stevilaList[min])
                        min = i;

                tmp = stevilaList[min];
                stevilaList[min] = stevilaList[prvi];
                stevilaList[prvi] = tmp;
            }
            return stevilaList.ToString().Trim();

        }

        //UREJANJE Z MEHURJEM
        public string Urejanjemehur()
        {
            
                int i, j, temp;
                bool zamen;
                for (i = 0; i < dolzina - 1; i++)
                {
                    zamen = false;
                    for (j = 0; j < dolzina - i - 1; j++)
                    {
                        if (stevilaList[j] > stevilaList[j + 1])
                        {
                            temp = stevilaList[j];
                            stevilaList[j] = stevilaList[j + 1];
                            stevilaList[j + 1] = temp;
                            zamen = true;
                        }
                    }

                    if (zamen == false)
                    {
                        break;
                    }

                }
            return stevilaList.ToString();
        }

        //DODAJ IN UREDI
        /* public void DodajInUredi(int value)
         {
              stevilaList.Add(value);

              int prvi;
              int min;
              int i, tmp;

              for (prvi = 0; prvi < stevilaList.Max(); prvi++)
              {
                  min = prvi;
                  for (i = prvi + 1; i < stevilaList.Max(); i++)
                      if (stevilaList[i] < stevilaList[min])
                          min = i;

                  tmp = stevilaList[min];
                  stevilaList[min] = stevilaList[prvi];
                  stevilaList[prvi] = tmp;
              }
             var numbers = stevilaList.Items.Cast<int>().ToList();
             if ()
         }*/
        public string DodajInUredi( int x)
        {
            bool isSorted = true;
            for (int i = 0; i < stevilaList.Count - 1; i++)
            {
                if (stevilaList[i] > stevilaList[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            if (!isSorted)
                throw new Exception("Tabela ni urejena.");

            int index = 0;
            while (index < stevilaList.Count && stevilaList[index] < x)
            {
                index++;
            }

            stevilaList.Insert(index, x);
            return stevilaList.ToString();
        }
    }
}
