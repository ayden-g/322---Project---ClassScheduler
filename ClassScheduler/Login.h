#ifndef LOGIN_H
#define LOGIN_H

#include <string>
#include <map>
using namespace std;

bool validateLogin(string username, string password, map<std::string, std::string> registeredUsers);

#endif
