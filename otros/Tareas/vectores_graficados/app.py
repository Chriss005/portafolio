import math
import matplotlib.pyplot as plt

def pedirComponentes():
    X = float(input("Introduce la componente X del vector: "))
    Y = float(input("Introduce la componente Y del vector: "))
    return X, Y

def mostrarFormaVectorial(X, Y):
    print(f"Forma vectorial: ({X}, {Y})")

def obtenerCuadrante(x, y):
    if(x > 0 and y > 0):
        return 1
    elif(x < 0 and y > 0):
        return 2
    elif(x < 0 and y < 0):
        return 3
    elif(x > 0 and y < 0):
        return 4
    
def calcularModulo(x, y):
    return math.sqrt(math.pow(x, 2) + math.pow(y, 2))


def graficarVector(x, y):
    plt.figure()
    plt.axhline(0, color='gray', linewidth=0.5)
    plt.axvline(0, color='gray', linewidth=0.5)
    plt.quiver(0, 0, x, y, angles='xy', scale_units='xy', scale=1, color='blue')
    plt.xlim(-10, 10)
    plt.ylim(-10, 10)
    plt.grid()
    plt.title("Vector en el plano")
    plt.xlabel("X")
    plt.ylabel("Y")
    plt.gca().set_aspect('equal', adjustable='box')
    plt.show()

def main():

    X, Y = pedirComponentes()
    
    mostrarFormaVectorial(X, Y)

    modulo = calcularModulo(X, Y)
    print(f"Módulo del vector: {modulo}")

    cuadrante = obtenerCuadrante(X, Y)
    print(f"Cuadrante: {cuadrante}")

    graficarVector(X, Y)

    input("\nPresiona Enter para salir...")

if __name__ == "__main__":
    main()
