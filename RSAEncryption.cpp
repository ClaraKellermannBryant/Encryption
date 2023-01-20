// This project is for implementing the Rivest Shamir Adelman encryption algorithm, which is utilized in various secure communications strategies.

// RSA is an asymmetric encryption algorithm that can be utilized in digital signatures for protecting information transmitted 
// between two parties.

#include <iostream>
#include <math.h>


using namespace std;

int greatestCommonDenominator(int i, int h) {
    int b;
    while (1) {
        // We take the modulus of i and h for the gcd, and we want boolean values to ensure the gcd between e and phi is 1.
        b = i % h;
        if (b == 0)
            return h;
            i = h;
            h = b;
    }
}

int main()
{
    // We are going to create a p and a q for RSA, the product n, the product phi, and the secret component that is to be validated.
    // Rabin e uses 2, so we shall use 2 as well for e.

    double p = NULL;
    double q = NULL;
    double n = p * q;
    double e = 2;
    double j = 250; // Arbitrary and used for overflow testing
    double d{};
    double counts;
    double phi = (p - 1) * (q - 1);
    
    // The declaration and initialization for calculating RSA are here

    // Decryption for RSA begins with initializing d 

    d = (1 + (j * phi)) / e;

     double message = 275835; //This is our example message

     double g = pow(message, e);
     double r = pow(g, d);
     
     g = fmod(g, n);
     r = fmod(r, n);

   

    // The first prime number chosen by the user is entered here.
    cout << "Enter prime number p:";
    cin >> p;


    // The second prime number chosen by the user is entered here.
    cout << "Enter prime number q:";
    cin >> q;

    // Encrypted and decrypted output
    cout << "Content Encrypted:  /n" << g;

    cout << "Decrypted Message:  /n" << r;


    while (e < phi) {
        counts = greatestCommonDenominator(e, phi);
        if (counts == 1) {
            break;
        }
        else {
            e++;
        }
    }
    
    

   

    
}
