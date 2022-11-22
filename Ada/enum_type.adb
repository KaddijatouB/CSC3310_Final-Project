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
   
    begin
    STUDENT'Pos (GradeA);
    STUDENT'Val (1);
    STUDENT'Image (GradeA);
    STUDENT'Value ("GradeB");

end enum_type;