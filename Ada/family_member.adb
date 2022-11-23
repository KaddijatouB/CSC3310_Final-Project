with Ada.Text_IO; 
use Ada.Text_IO;

--  Create a family for record type 
procedure family_member is
     type Names is
     (Jerome, Kay, Jabin, Jacobi);
     
    type Relationship is
     (Mother, Father, Child);
     
  -- the family record will have type string and integer
  type Family is record
  Name      : Names;
  Relation  : Relationship;
  Age       : Integer;
  end record;
  
  -- Method to print out record information 
  procedure Print_Member(Joof : Family) is
   begin
      -- use the Image attribute to print values
      Put_Line ("Name:" & Names'Image (Joof.Name)
                & ", Relationship: "
                & Relationship'Image (Joof.Relation)
                & ", Age:"
                & Integer'Image (Joof.Age));
  end Print_Member;

  --list each family member info 
  Joof_Member1 : Family := (Jerome, Father, 32);
  Joof_Member2 : Family := (Kay, Mother, 30);
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
