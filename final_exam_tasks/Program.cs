// See https://aka.ms/new-console-template for more information

using final_exam_tasks;

var names = new List<string> { "Mike", "Selena", "Andy" };
var arrayOfUpperCaseNames = names.ToList().Where(n =>n.ToCharArray().ToList().All(ch=>Char.IsUpper(ch)));


var cities = new List<string>{"Amsterdam", "Berlin", "Minsk","Bereza"};
var substitutionChar = 'S';
var sortedCities = from c in cities where c.Length % 2 == 0 select c;
sortedCities.ToList().ForEach(c => c = substitutionChar + c.Substring(1));


GenericClassStudent myStudent = new GenericClassStudent();
myStudent.GenericMethod("Hello");


