using System.Runtime.InteropServices;

namespace EmpAssignment200824
{
    class Company
    {
        public int cid { get; set; }
        public string name { get; set; }
        
        Employee[] emps;
        public Company(Employee[]e )
        {

            emps = e;
            
        }
        public  void showAllEmployees()
        {
            for (int i = 0; i < emps.Length; i++)
            {
                // Console.WriteLine(eeArray[i]);
                Console.Write(emps[i].ID);
                Console.Write(" " + emps[i].Name);
                Console.Write(" " + emps[i].salary);
                Console.WriteLine(" " + emps[i].dept);

            }
        }

    }

    struct Employee
    {
       public int ID;
        public string Name;
        public int salary;
        public string dept;

        public void showEmp()
        {
            Console.WriteLine($"ID={ID} Name={Name} Salary={salary} Dept={dept}");
        }
        public void increment()
        {
            if (salary < 5000) 
            {
                salary += 1000;
            }
            else if (salary>=5000 && salary<1000)
            {
                salary = salary + 2000;
            }
            else
            {
                salary = salary + 5000;
            }

        }
        
    }

    internal class Program
    {
     
        public static string[] uniqeStrings(string[] st)
        {
            string[]output=new string[st.Length];          

            for (int i = 0; i < st.Length; i++)
            {
                for (int m = i + 1; m < st.Length; m++)
                {
                    if (string.Compare(st[i], st[m]) > 0)
                    {
                        string tt = st[i];
                        st[i] = st[m];
                        st[m] = tt;
                    }
                }
            }
            Console.WriteLine("------------");
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(st[i]);
            }
            Console.WriteLine("-------------------");
            int j = 0;
          
            for (int i = 0; i < st.Length; )
            {
                int cnt = 1;
                for (int k = i+1; k < st.Length; k++)
                {
                   
                    if (string.Compare(st[i], st[k]) == 0)
                    {
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
                output[j++] = st[i];
                i = i + cnt;

            }
            //Console.WriteLine("------output array-----------");
            //for (int i = 0; i < j; i++)
            //{
            //    Console.WriteLine(output[i]);
            //}
            return output;
           
        }
        static public void MaxSalEmpByDept(Employee[] emps, string dp)
        {
            Employee maxSalEmp = new Employee();
            //Employee maxSalEmp;
            //maxSalEmp.salary = 0;
            //maxSalEmp.ID = 0;
            //maxSalEmp.Name = null;
            //maxSalEmp.dept = null;
            for (int i = 0; i < emps.Length; i++)
            {       //true       &&           true
                    //   2222<4444   &&  HR ==HR
                if (maxSalEmp.salary < emps[i].salary && emps[i].dept == dp)//HR
                {
                    maxSalEmp = emps[i];//4444
                }
            }
            maxSalEmp.showEmp();
        }

        static public void showIntArray(int[] iArray)
        {
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine(iArray[i]);
            }
        }
        
        public static void TotalSalaryPaid(Employee[] eeArray)
        {
            int totalSal = 0;
            for (int i = 0; i < eeArray.Length; i++)
            {
                // Console.WriteLine(eeArray[i]);
                totalSal = totalSal + eeArray[i].salary;
            }
            Console.WriteLine("Total Salary Paid to All Employees ="+totalSal);
        }
        public static void TotalSalaryPaidToHR(Employee[] eeArray,string dept)
        {
            int totalSal = 0;
            for (int i = 0; i < eeArray.Length; i++)
            {
                if (String.Compare(eeArray[i].dept, dept) == 0)
                {
                    totalSal = totalSal + eeArray[i].salary;
                }
            }
            Console.WriteLine("Total Salary Paid to All Employees =" + totalSal);
        }

        public static void showEmployeeById(Employee[] eeArray,int empid)
        {
            bool flagEmp = true;

            for (int i = 0; i < eeArray.Length; i++)
            {
                if (eeArray[i].ID == empid)
                {
                    flagEmp = false;
                    Console.Write(eeArray[i].ID);
                    Console.Write(" " + eeArray[i].Name);
                    Console.Write(" " + eeArray[i].salary);
                    Console.WriteLine(" " + eeArray[i].dept);
                    break;
                }          
            }
            if (flagEmp)
            {
                Console.WriteLine("Employee not found");
            }
        }
        public static void showEmployeeByName(Employee[] eeArray, String empName)
        {
            bool flagEmp = false;

            for (int i = 0; i < eeArray.Length; i++)
            {
                if (String.Compare( eeArray[i].Name,empName)==0)
                {
                    flagEmp = true;
                    Console.Write(eeArray[i].ID);
                    Console.Write(" " + eeArray[i].Name);
                    Console.Write(" " + eeArray[i].salary);
                    Console.WriteLine(" " + eeArray[i].dept);
                    //break;
                }
            }
            if (flagEmp == false)
            {
                Console.WriteLine("Employee not found");
            }
        }

        public static void showEmployeeByDept(Employee[] eeArray, String dp)
        {
            bool flagEmp = false;

            for (int i = 0; i < eeArray.Length; i++)
            {
                if (String.Compare(eeArray[i].dept,dp) == 0)
                {
                    flagEmp = true;
                    Console.Write(eeArray[i].ID);
                    Console.Write(" " + eeArray[i].Name);
                    Console.Write(" " + eeArray[i].salary);
                    Console.WriteLine(" " + eeArray[i].dept);
                    
                }
            }
            if (flagEmp == false)
            {
                Console.WriteLine("Employee not found");
            }
        }

        static void Main(string[] args)
        {
            Employee[] emps = new Employee[] {
              new Employee{ ID=1,Name="rajesh",salary=1111,dept="IT"},
              new Employee{ ID=2,Name="dinesh",salary=2222,dept="HR"},
              new Employee{ ID=3,Name="rajesh",salary=3333,dept="Sales"},
              new Employee{ ID=4,Name="darshan",salary=4444,dept="hr"},
            };

            //int[] i = new int[] { 11, 22, 33, 44 };
            //showIntArray(i);
            Company c1 = new Company(emps);
            c1.cid = 1;
            c1.name = "TCS";
            c1.showAllEmployees();
            //TotalSalaryPaidToHR(emps,"HR");
            //Console.WriteLine("enter employee id to Search employee");
            //int eid = int.Parse(Console.ReadLine());
            //showEmployeeById(emps, eid);

            //Console.WriteLine("---------------------");
            //Console.WriteLine("enter employee dept to Search employee");
            //string ed = Console.ReadLine();
            //showEmployeeByDept(emps, ed);
            //---------------------------------------------------------------------------------
            //string[] AllEmpDepts = new string[emps.Length];
            //for (int i = 0; i < emps.Length; i++)
            //{
            //    AllEmpDepts[i] = emps[i].dept;
            //}
            //Console.WriteLine("--Before filter depts are ----");
            //for (int i = 0; i < AllEmpDepts.Length; i++)
            //{
            //    Console.WriteLine(AllEmpDepts[i]);
            //}
            //var depts = uniqeStrings(AllEmpDepts);
            //Console.WriteLine("--after filter depts are ----");
            //for (int i = 0; i < depts.Length; i++)
            //{
            //    Console.WriteLine(depts[i]);
            //}
            ////MaxSalEmpByDept(emps, "IT");

            //Console.WriteLine("dept wise max salary employee---");

            //for (int i = 0; i < depts.Length; i++)
            //{
            //    if (depts[i]!=null)
            //    {
            //        MaxSalEmpByDept(emps, depts[i]);//
            //    }
                
            //}

            //int R;

            //int[] IArrr;


        }

    }
}


// All dept find  IT, HR, Sales