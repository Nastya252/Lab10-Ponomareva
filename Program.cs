using System.Diagnostics.CodeAnalysis;

string subject = "Программирование";
foreach (char letter in subject) {
    Console.WriteLine(letter);
}
Console.WriteLine(subject.Length);

int[] grades = {4, 5, 3, 5, 4};
int sum = 0;
int count = 0;
foreach (int grade in grades) {
    Console.WriteLine(grade);
    sum+=grade;
    count++;
}
Console.WriteLine(sum);
Console.WriteLine((double)sum/count);

string[] students = {"Аня", "Ярослав", "Вика"};
int count = 0;
foreach (string student in students) {
    Console.WriteLine(student);
    count++;
}
Console.WriteLine(count);

int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++){
    points[i] += 5;
}
for (int i = 0; i < points.Length; i++){
    Console.WriteLine(points[i]);
}

string[] students = {"Аня", "Борис", "Вика"};
int number = 1;
foreach (string student in students) {
    Console.WriteLine($"{number}. {student}");
    number++;
}

/*
Задача В. Дано слово (строка без пробелов). 
С помощью foreach посчитайте, 
сколько в нём гласных букв.
*/
string word = "Татьяна";
int count = 0;
string gl = "аеиоуыэюяАЕИОУЫЭЮЯ";
foreach (char alp in word) {
    if (gl.Contains(alp)){
        count++;
    }
}
Console.WriteLine(count);

/*
Задача Г. Дан массив int[] с оценками. 
С помощью foreach и переменной
накопителя «текущий максимум» найдите наибольшую оценку. 
*/
int[] grades = {5,2,7,25};
int maxgrade = 0;
foreach (int grade in grades) {
    if (grade>= maxgrade) {
        maxgrade = grade;
    }
}
Console.WriteLine(maxgrade);


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

/*
Вариант 4. Дорогие товары 
Дан массив int[] с ценами товаров. 
Посчитайте общую сумму всех цен и отдельно 
— количество товаров дороже 500 рублей. 
*/
int[] prices = {505,143,500,451};
int count = 0;
int sum = 0;
foreach (int price in prices){
    if (price>500) {
        count++;
    }
    sum+=price;
}
Console.WriteLine($"Общая сумма: {sum}");
Console.WriteLine($"Количество товаров дороже 500 рублей: {count}");

/*
Вариант 9. Исправление через for 
Дан массив int[]. Сначала попробуйте увеличить 
каждый элемент на 1 с помощью 
foreach (убедитесь, что код не компилируется), 
затем исправьте задачу с помощью 
обычного for с индексом и выведите итоговый массив. 
*/
int[] number = {5,7,777, 33};
for (int i = 0; i < number.Length; i++) {
    number[i] ++;
    Console.WriteLine(number[i]);
}

string[] names = { "София", "Маша", "Оля", "Ваня", "Саша" };
int[] grades = { 5, 4, 4, 2, 3 };
int sum = 0;
int maxGrade = grades[0];
string best = names[0];
for (int i = 0; i < names.Length; i++){
    Console.WriteLine($"{names[i]} - {grades[i]}");
    sum += grades[i];
    if (grades[i] > maxGrade){
        maxGrade = grades[i];
        best = names[i];
    }
}
double average = (double)sum / names.Length;
Console.WriteLine($"Средний балл по классу: {average:F2}");
Console.WriteLine($"Лучшая оценка: {maxGrade}");
Console.WriteLine($"Лучший ученик: {best}");
