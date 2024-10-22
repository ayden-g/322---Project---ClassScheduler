#ifndef USER_H
#define USER_H

#include <string>
#include <map>

using namespace std;

class User {
private:
    string registerdUsername;
    string registerdPassword;

public:
    User();
    User(string username, string password);

    static map<string, string> registerUser(map<string, string> registeredUsers);

    static bool validateLogin(const string& username, const string& password, const map<string, string> registeredUsers);
};

#endif
