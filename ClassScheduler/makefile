output: source.o Course.o Login.o User.o
	g++ -g -std=c++11 source.o Course.o Login.o User.o -o output

source.o: Source.cpp 
	g++ -g -std=c++11 -c Source.cpp -o source.o

Course.o: Course.cpp Course.h
	g++ -g -std=c++11 -c Course.cpp -o Course.o

Login.o: Login.cpp Login.h
	g++ -g -std=c++11 -c Login.cpp -o Login.o

User.o: User.cpp User.h
	g++ -g -std=c++11 -c User.cpp -o User.o

clean:
	rm *.o output


