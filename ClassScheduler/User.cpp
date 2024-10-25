#include <iostream>
#include <map>
#include <string>
#include "User.h"

using namespace std;

	User::User() {}

	User::User(string username, string password, userType access) {
		registeredUsername = username;
		registeredPassword = password;
        registeredAccess = access;
	}

    map<string, User> User::registerUser(map<string, User> registeredUsers) {
        string uniID; 
        string newPassword;

        cout << "Enter your WSU ID: ";
        cin >> uniID;

        if (registeredUsers.find(uniID) != registeredUsers.end()) {
            cout << "You are a " << userTypeToString(registeredUsers[uniID].registeredAccess) << endl;
            cout << "Enter a new password: ";
            cin >> newPassword;
            registeredUsers[uniID].registeredPassword = newPassword;
            cout << "User registered successfully" << endl;
            return registeredUsers;
        }
        else {
            cout << "You are a not student/professor/admin" << endl;
            return registeredUsers;
        }
    }

    bool User::validateLogin(const string& username, const string& password) const{
        if(registeredUsername == username && registeredPassword == password){
            return true;
        }
        return false;
    }


