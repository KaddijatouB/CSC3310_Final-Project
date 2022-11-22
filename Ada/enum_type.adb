with Ada.Text_IO; 
use Ada.Text_IO;

procedure enum_type is
-- Declay an enum for family member names
    type MyFamily is
    (
        Jerome,
        Kay,
        Jabin,
        Jacobi,
        Michaella,
        Donald
    );

    for MyFamily use 
    (
        Jerome => Mother,
        Kay => Father,
        Jabin => Son,
        Jacobi => Son,
        Michaella => GrandMother,
        Donald => GrandFather);
   
    begin

end enum_type;