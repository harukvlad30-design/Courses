namespace Courses.Models;

public class Course
{
    public int Id { get; set; }

    public string Title { get; set; } = ""; // Назва курсу (обов'язкова)

    public string? Description { get; set; } // Короткий опис або нотатки (може бути відсутній)

    public int DurationHours { get; set; } // Обсяг навчання у годинах (для зведень за періодами)

    public decimal Price { get; set; } // Вартість курсу (0, якщо безкоштовний)

    public DateOnly StartedOn { get; set; } // Дата початку навчання (обов'язкова)

    public DateOnly? CompletedOn { get; set; } // Дата завершення (може бути відсутня, якщо ще триває)

    public CourseStatus Status { get; set; } // Статус проходження (перелік enum)
}