// using System.Diagnostics.CodeAnalysis;

// string subject = "Программирование";
// foreach (char letter in subject) {
//     Console.WriteLine(letter);
// }
// Console.WriteLine(subject.Length);

// int[] grades = {4, 5, 3, 5, 4};
// int sum = 0;
// int count = 0;
// foreach (int grade in grades) {
//     Console.WriteLine(grade);
//     sum+=grade;
//     count++;
// }
// Console.WriteLine(sum);
// Console.WriteLine((double)sum/count);

// string[] students = {"Аня", "Ярослав", "Вика"};
// int count = 0;
// foreach (string student in students) {
//     Console.WriteLine(student);
//     count++;
// }
// Console.WriteLine(count);

int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++){
    points[i] += 5;
}
for (int i = 0; i < points.Length; i++){
    Console.WriteLine(points[i]);
}