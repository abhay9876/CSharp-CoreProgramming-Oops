
/*University Management System
Description: Model a university system with Student, Professor, and Course classes. Students
enroll in courses, and professors teach courses. Ensure students and professors can
communicate through methods like EnrollCourse() and AssignProfessor().
Goal: Use association and aggregation to create a university system that emphasizes
relationships and interactions among students, professors, and courses.*/


using System;

class Learner
{
    public string Name { get; }

    public Learner(string name)
    {
        Name = name;
    }

    // Communication
    public void EnrollSubject(Subject subject)
    {
        Console.WriteLine($"{Name} enrolled in {subject.Title}");
        subject.AddLearner(this);
    }
}

class Instructor
{
    public string Name { get; }

    public Instructor(string name)
    {
        Name = name;
    }

    // Communication
    public void AssignToSubject(Subject subject)
    {
        Console.WriteLine($"{Name} assigned to teach {subject.Title}");
        subject.AssignInstructor(this);
    }
}

class Subject
{
    public string Title { get; }

    private List<Learner> learners = new();
    private Instructor instructor;

    public Subject(string title)
    {
        Title = title;
    }

    // Aggregation Learner comes from outside
    public void AddLearner(Learner learner)
    {
        learners.Add(learner);
    }

    // Aggregation Instructor comes from outside
    public void AssignInstructor(Instructor instructor)
    {
        this.instructor = instructor;
    }
}