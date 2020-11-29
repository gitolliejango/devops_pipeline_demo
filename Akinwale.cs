    
    
using System;  
using System.Collections.Generic;  
using Newtonsoft.Json;
    

namespace Akinwale{
class Alltypes2{
string height;
string baby_name;
    
        public void Wanton(){

            height = "100";
            baby_name = "The name";
        }

        public class Student   
        {  
            public string name {  
                get;  
                set;  
            }  
        }  


        public class Universities {  
            public string university {  
                get;  
                set;  
            }  
            public IList < Student > students {  
                get;  
                set;  
            }  
        }  
        public class ClassUniversities {  
            public Universities universities {  
                get;  
                set;  
            }  
        }  

        public void Display(){
            Console.WriteLine(height + " "  + baby_name);
           

        }

       

    }

     class Program  
        {  
            static void Main(string[] args)   
            {  
                university1 = newClassUniversities();
                university1.universities = newUniversities();  
                university1.universities.university = "South Carolina StateUniversity";  
      
                List < Student > listStudent = newList < Student > ();  
                Student student1 = newStudent ;{  
                    name = "StephenCousins"  ;
                } 
                Student student2 = newStudent; {  
                    name = "Austin A. Newton" ; 
                }
                Student student3 = newStudent; {  
                    name = "Adam Wilhite";  
                }
                Student student4 = newStudent; {  
                    name = "Enis Kurtay YILMAZ" ; 
                }  
      
                listStudent.Add(student1);  
                listStudent.Add(student2);  
                listStudent.Add(student3);  
                listStudent.Add(student4);  
      
                university1.universities.students = listStudent;  
                stringjson = JsonConvert.SerializeObject(university1);  
      
                Console.WriteLine(json);  
                Console.ReadLine();  
            }  
        }  

}























