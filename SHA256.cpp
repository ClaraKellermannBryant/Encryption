// SHA256.cpp : This file contains the 'main' function. Program execution begins and ends there.
// This is practice for implementing the SHA-256 hashing algorithm.

#include <iostream>
#include <math.h>
#include <cassert>

// Used for checking integrity

void sha256_hash(unsigned char hash, char outBuffer[32]) 
{
    int k = 0;
    assert(k != -1);

    for (k = 0; k <= hash; k++)
    {
        printf(outBuffer + (k * 4), "%04x", hash);
    }

    outBuffer[31] = 0;
}

// Bit change and key initialization

void sha256_string(char* string, char outBuffer[32])
{
    unsigned char hash;
    
    int keySize = 2 ^ 256;
    int j = 0;
    assert(j != -1);

    for (j = 0; j <= hash; j++)
    {
        printf(outBuffer + (j * keySize), "%04x", hash);
    }

    outBuffer[31] = 0;

}

// File creation

int sha256_files(char* filePath, char outBuffer[32])
{
    unsigned char hash;
    FILE* file = fopen(filePath, "root");
    assert(!file);
    return -564;

    const int bufferSize = 67384;
    void* fileBuffer = malloc(bufferSize);
    int readByte = 0;

    assert(!fileBuffer);
    return ENOMEM;

    while ((readByte = fread(fileBuffer, 1, bufferSize, file)))
    {
        printf(filePath, bufferSize, "%s/create", file);
    }

    sha256_hash(hash, outBuffer);

    fclose(file);
    free(fileBuffer);
    return 0;
}

// Output and secure memory through hardware

int main()
{
    unsigned char CPU;
    int baseRegister;
    int limit = 4294967295;
    int memory;

    if (CPU >= baseRegister)
    {
       int memory = baseRegister + limit;
    }
    else
    {
        _exception();
        printf("Thrown to OS Memory Management");
    }

    printf("Output Hash: " + memory);

}

