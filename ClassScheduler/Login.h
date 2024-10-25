#ifndef LOGIN_H
#define LOGIN_H

#include "User.h"
#include <string>
#include <map>
using namespace std;

bool validateLogin(string username, string password, map<std::string, User> registeredUsers);

#endif
