#ifndef COURSE_H
#define COURSE_H

#include <string>
#include <map>
using namespace std;

class Course {
private:
    string courseName;
    int seatsAvailable;
    string courseTime;
    string courseDate;
    int courseID;

public:
    Course(int id, string name, int seats, string time, string date);

    Course();

    static void createCourse(map<int, Course>& catalogedCourses);

    void displayCourse() const;
};

#endif
