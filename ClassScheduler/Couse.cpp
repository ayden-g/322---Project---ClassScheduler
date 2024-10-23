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

bool Course::isTimeSlotAvailable(const map<int, Course>& catalogedCourses, const string& time, const string& date) 
{
    for (const auto& pair : catalogedCourses) 
    {
        if (pair.second.courseTime == time && pair.second.courseDate == date) 
        {
            return false; // Time slot is already taken
        }
    }
    return true; // Time slot is available
}

void Course::createCourse(map<int, Course>& catalogedCourses) 
{
    int id;
    int seats;
    string name;
    string time; 
    string date;

    cout << "Enter course ID: ";
    cin >> id;

    // Check if course ID already exists
    if (catalogedCourses.find(id) != catalogedCourses.end()) 
    {
        cout << "Course ID already exists. Please enter a unique ID." << endl;
        return;
    }

    cout << "Enter course name: ";
    cin.ignore(); // Clear the buffer before getting a line input
    getline(cin, name);
    
    cout << "Enter seats available: ";
    cin >> seats;

    cout << "Enter course time (e.g., 10:00 AM): ";
    cin.ignore();
    getline(cin, time);
    
    cout << "Enter course date (e.g., 2024-10-22): ";
    getline(cin, date);

    // Validate time slot availability
    if (!isTimeSlotAvailable(catalogedCourses, time, date)) 
    {
        cout << "Time slot is not available. Please choose a different time." << endl;
        return;
    }

    Course newCourse(id, name, seats, time, date);
    catalogedCourses[id] = newCourse;

    cout << "Course created successfully!" << endl;
}

// Method to display course details
void Course::displayCourse() const 
{
    cout << "Course ID: " << courseID << endl;
    cout << "Course Name: " << courseName << endl;
    cout << "Seats Available: " << seatsAvailable << endl;
    cout << "Time: " << courseTime << endl;
    cout << "Date: " << courseDate << endl;
    cout << "-------------------------" << endl;
}
