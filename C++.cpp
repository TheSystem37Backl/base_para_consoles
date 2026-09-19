#include <iostream>
#include <string>
#include <vector>

// cria o nosso string para colocar a string do user
std::string INPUT_STRING;

auto lexer(std::string input) {
    // aqui você pode colocar qualquer lexer que precisar
    // o que é um lexer: 
    /*
         Um **lexer** é um programa que lê o código-fonte e o divide em partes chamadas *tokens*.
        Cada token representa palavras-chave, símbolos ou valores.
         Ele funciona como um tradutor inicial, ajudando o compilador ou interpretador a entender o texto.
        Em programação de console, é o primeiro passo para processar comandos.
    */
}

int main() {
    // defini um loop
    while (true) {
        // mostrar "TheSl>" na tela
        std::cout << "TheSl>" << std::endl;
        // ler a linha
        std::getline(std::cin, INPUT_STRING);
        // manda para o lexer
        lexer(INPUT_STRING);

        // aqui você pode processar os tokens de qualquer forma, usando IFs ou sendo modular (usando std::map ou qualquer forma)
    }
}
