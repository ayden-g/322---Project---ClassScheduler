#ifndef USER_H
#define USER_H

#include <string>
#include <map>

using namespace std;
enum userType {STUDENT, PROFFESOR, ADMIN};
std::string userTypeToString(userType type) {
    switch (type) {
        case STUDENT: return "Student";
        case PROFFESOR: return "Proffesor";
        case ADMIN: return "Admin";
        default: return "Unknown";
    }
}


class User {
private:
    string registeredUsername;
    string registeredPassword;
    userType registeredAccess; 

    
public:
    User();
    User(string username, string password, userType access);

    static map<string, User> registerUser(map<string, User> registeredUsers);

    bool validateLogin(const string& username, const string& password) const;
};

#endif
