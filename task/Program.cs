namespace ALL_student
{

    class StudentInfo
    {
        static Student GetStudent(){
            Random random_mark = new();
            Student student = new Student();
            student.first_name = "Ivan";
            student.last_name = "Ivanov";
            student.age = 17;
            student.gender = true;
            student.groupe = "7N";
            student.character = "заебись четко";
            student.ColMark = 10;

            student.assessment = new int[student.ColMark];
            for(int i = 0;i < student.assessment.Length;i++){
                student.assessment[i] = random_mark.Next(1,100);
            }

            return student;
        }
        static FriendStudent GetFriendStudent(){
            FriendStudent friend_student = new FriendStudent();
            friend_student.first_name_friend = "Вова";
            friend_student.second_name_friend = "Иванов";
            friend_student.reliable = false;
            friend_student.age_friend = 10;
            friend_student.family = "Dad,Mom";
            friend_student.police = false;

            return friend_student;
        }
        static void Main(){
            Student first_student = GetStudent();
            first_student.GetFullName();
            first_student.PrintAssesments();
            
            FriendStudent first_friend_student = GetFriendStudent();
            first_friend_student.GetFullNameFriend();
        }
    }
}










































































































































