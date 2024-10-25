#include "Login.h"
#include <iostream>
#include <map>
#include <string>
using namespace std;

bool validateLogin(string username, string password, const map<string, User> userDatabase) {
    for (const auto& pair : userDatabase) {
        if (pair.first == username && pair.second.validateLogin(username,password)) {
            return true;
        }
        else {
            return false;
        }
    }
    return false;
}