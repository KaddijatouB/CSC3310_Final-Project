with Ada.Text_IO; 
use Ada.Text_IO;

--  Create a family for record type 
procedure family_member is

  type Family is record
  Name      : String ;
  Relation  : String;
  Age       : Integer;
  end record;

  --Declare a family 
  Joof : Family;

  begin
    Joof.Name := Jerome;
    Joof.Relation := Father;
    Joof.Age := 36;
   
end family_member;
