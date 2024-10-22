#include <iostream>
#include <map>
#include <string>
#include "Course.h"

using namespace std;

Course::Course() {}

Course::Course(int id, string name, int seats, string time, string date) {
    courseID = id;
    courseName = name;
    seatsAvailable = seats;
    courseTime = time;
    courseDate = date;
}

void Course::createCourse(map<int, Course>& catalogedCourses) {
    int id;
    int seats;
    string name;
    string time; 
    string date;

    cout << "Enter course ID: ";
    cin >> id;
    cout << "Enter course name: ";
    cin >> name;
    cout << "Enter seats available: ";
    cin >> seats;
    cout << "Enter course time: ";
    cin >> time;
    cout << "Enter course date: ";
    cin >> date;

    Course newCourse(id, name, seats, time, date);
    catalogedCourses[id] = newCourse;
}

// Method to display course details
void Course::displayCourse() const {
    cout << "Course ID: " << courseID << endl;
    cout << "Course Name: " << courseName << endl;
    cout << "Seats Available: " << seatsAvailable << endl;
    cout << "Time: " << courseTime << endl;
    cout << "Date: " << courseDate << endl;
    cout << "-------------------------" << endl;
}
