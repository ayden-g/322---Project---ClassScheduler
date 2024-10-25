#ifndef USER_H
#define USER_H

#include <string>
#include <map>

using namespace std;
enum userType {STUDENT, PROFFESOR, ADMIN};



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

    static string userTypeToString(const userType type);

};

#endif
