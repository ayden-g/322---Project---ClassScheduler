#include <iostream>
#include <map>
#include <string>
#include "Login.h"
#include "Course.h"
#include "User.h"

using namespace std;

int main() {
    string username;
    string password;

    User user("","",STUDENT);
    
    map<string, User> unregisteredUsers = {{"123",user}};
    map<int, Course> catalogedCourses;

    cout << "Register new user: " << endl;

    map<string, User> registeredUsers = User::registerUser(unregisteredUsers);

    cout << "Now log in: " << endl;

    cout << "Username: ";
    cin >> username;
    cout << "Password: ";
    cin >> password;

        if (validateLogin(username, password, registeredUsers)) {
            cout << "Login successful";

            int input;
            while (true) {
                cout << "\n1. Create a course";
                cout << "\n2. View the Schedule";
                cout << "\n3. Quit";
                cout << "\n------> ";
                cin >> input;

                switch (input) {
                case 1:
                    Course::createCourse(catalogedCourses);
                    break;

                case 2:
                    if (catalogedCourses.empty()) {
                        cout << "Schedule is empty";
                    }
                    else {
                        for (const auto& pair : catalogedCourses) {
                            pair.second.displayCourse();
                        }
                    }
                    break;

                case 3:
                    return 0;

                default:
                    cout << "Invalid option. Please try again.";
                    break;
                }
            }
        }
        else {
            cout << "Login failed";
        }
    return 0;
}
