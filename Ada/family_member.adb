with Ada.Text_IO; 
use Ada.Text_IO;

--  Create a family for record type 
procedure family_member is
  -- the family record will have type string and integer
  type Family is record
  Name      : String;
  Relation  : String;
  Age       : Integer;
  end record;
  -- Method to print out record information 
  procedure Print_Member(Joof : Family) is
   begin
      Put_Line ("Name:" & String'Image (Joof.Name)
                & ", Relationship: "
                & String'Image (Joof.Relation)
                & ", Age:"
                & Integer'Image (Joof.Age));
  end Print_Member;

  --list each family member info 
  Joof_Member1 : Family := (Jerome, Father, 36);
  Joof_Member2 : Family := (Kay, Mother, 32);
  Joof_Member3 : Family := (Jabin, Child, 3);
  Joof_Member4 : Family := (Jacobi, Child, 1);

  begin
    --Display family infomation
    Put_Line("The Joof Family");
    Print_Member(Joof_Member1);
    new_line;
    Print_Member(Joof_Member2);
    new_line;
    Print_Member(Joof_Member3);
    new_line;
    Print_Member(Joof_Member4);
    
-- end of the family procedure
end family_member;
