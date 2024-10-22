#include "Login.h"
#include <iostream>
#include <map>
#include <string>
using namespace std;

bool validateLogin(string username, string password, const map<string, string> userDatabase) {
    for (const auto& pair : userDatabase) {
        if (pair.first == username && pair.second == password) {
            return true;
        }
        else {
            return false;
        }
    }
    return false;
}