#include <iostream>
#include <map>
#include <string>
#include "User.h"

using namespace std;

	User::User() {}

	User::User(string username, string password) {
		registerdUsername = username;
		registerdPassword = password;
	}

    map<string, string> User::registerUser(map<string, string> registeredUsers) {
        string uniID; 
        string newPassword;

        cout << "Enter your WSU ID: ";
        cin >> uniID;

        if (registeredUsers.find(uniID) != registeredUsers.end()) {
            cout << "You are a student/professor/admin" << endl;
            cout << "Enter a new password: ";
            cin >> newPassword;
            registeredUsers[uniID] = newPassword;
            cout << "User registered successfully" << endl;
            return registeredUsers;
        }
        else {
            cout << "You are a not student/professor/admin" << endl;
            return registeredUsers;
        }
    }


