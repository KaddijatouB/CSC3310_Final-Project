with Ada.Text_IO; 
use Ada.Text_IO;

procedure enum_type is
-- Declay an enum for family member names
    type STUDENT is
    (
        GradeA, 
        GradeB, 
        GradeC, 
        GradeD, 
        GradeE
    );
   Student_Grade1 : STUDENT;
   Student_Grade2 : STUDENT;
   Student_Grade3 : STUDENT;
   Student_Grade4 : STUDENT;

    begin
    --print enum vaules using attribues 
    Student_Grade1 := STUDENT'First;
    Put_Line (STUDENT'Image(Student_Grade1) 
    & " is the highest grade possible");

    Student_Grade2 := STUDENT'Last;
    Put_Line (STUDENT'Image(Student_Grade2) 
    & " is the lowest grade possible");

    Student_Grade3 := STUDENT'Pred (GradeE);
     Put_Line (STUDENT'Image(Student_Grade3) 
    & " is a higher grade GradeE");

   
    Student_Grade4 := STUDENT'Succ (GradeB);
    Put_Line (STUDENT'Image(Student_Grade4) 
    & " is a lower grade than GradeB");


end enum_type;