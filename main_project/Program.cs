namespace ALL_student
{
    class Program
    {

        static int[] GetMark(Student first_student){
            first_student.Mark = new int[10];
            Random random_mark = new();
            for(int i = 0;i < first_student.Mark.Length;i++)
                first_student.Mark[i] = random_mark.Next(1,11);
            return first_student.Mark;

        }
        static float CountAvarageMark(Student first_student){
            float average_sum = 0;
            for(int i = 0;i < first_student.Mark.Length;i++){
                average_sum += first_student.Mark[i];
            }
            return average_sum / first_student.Mark.Length;
        }
        static double CountAge(Student first_student){
            double current_year = 2024.3;
            Random random_year_student = new();
            return Math.Round(current_year - (random_year_student.NextDouble() * 40),1);
        }
        static Student GetStudent()
        {
            DataSet MainData = CreatDataSet();
            Student first_student = new Student();
            Random random_index_DataSet = new();
            first_student.Date_of_Birth = CountAge(first_student);
            first_student.first_name = MainData.ALL_name[random_index_DataSet.Next(0,MainData.ALL_name.Length)];
            first_student.last_name = MainData.ALl_surrname[random_index_DataSet.Next(0,MainData.ALl_surrname.Length)];
            first_student.characther = MainData.ALL_combenetion[random_index_DataSet.Next(0,MainData.ALL_combenetion.Length)];
            first_student.Mark = GetMark(first_student);
            first_student.average_mark = CountAvarageMark(first_student);
            return first_student;
        }
        static DataSet CreatDataSet(){
            DataSet first_data = new DataSet();
            first_data.ALL_combenetion = new string[10]{"Следит за музыкальными новинками","Любит косплей","Немного высовывает язык когда думает","Любит природу","Любит танцевать на кухне","Цокает языком","Боится высоты","Ненавидит сладкое","Играет на укулеле","Не терпит слабых людей"};
            first_data.ALL_name = new string[10]{"Emma.","Olivia.","Sophia.","Ava.","Isabella.","Mia.","Abigail.","Emily.","Charlotte.","Harper."};
            first_data.ALl_surrname = new string[5]{"Abramson","Hoggarth","Adamson","Holiday","Adderiy"};
            return first_data;
        }
        static void Main(string[] args){
            while(true){
                Student first_student = GetStudent();
                first_student.PrintALlInfo();
            }
        }
    }
}