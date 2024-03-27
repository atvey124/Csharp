namespace ALL_student
{
    class Student
    {
        public string first_name="";
        public string last_name="";
        public double Date_of_Birth;
        public string characther="";
        public int[] Mark;
        public float average_mark;
        public void PrintALlInfo(){
            System.Console.WriteLine($"Date of Birth Student: {Date_of_Birth}");
            System.Console.WriteLine($"First name student: {first_name}");
            System.Console.WriteLine($"Last name student: {last_name} ");
            System.Console.WriteLine($"Characther student: {characther}");
            System.Console.WriteLine($"All mark: {string.Join(", ",Mark)}");
            System.Console.WriteLine($"Average mark: {average_mark}");
        }
        public void EditInfo(Student first_student){
            try
            {
                System.Console.Write("Input new characther student: ");
                first_student.characther = Console.ReadLine()!;
                System.Console.WriteLine("Student changed name(yes/no)?: ");
                string InputChanged = Console.ReadLine();

                if(InputChanged.ToLower() == "yes")
                {
                    System.Console.WriteLine("fill in the student's first and last name again: ");
                    string new_name_and_surname = Console.ReadLine();
                    string NewName="";
                    string NewSurname="";
                    for(int i = 0;i < new_name_and_surname.Length;i++){
                        if(new_name_and_surname[i] == ' '){
                            for(int j = i + 1;j < new_name_and_surname.Length;j++){
                                NewSurname += new_name_and_surname[j];
                            }
                            break;

                        }
                        else
                            NewName += new_name_and_surname[i];
                        
                    }
                    first_student.first_name = NewName;
                    first_student.last_name = NewSurname;
                }
                
            }
            catch{
                System.Console.WriteLine("Incorrect type");
            }


        }
        
        
        
    }
}