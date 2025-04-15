import math
import matplotlib.pyplot as plt

class Vector:
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def mostrarFormaVectorial(self):
        print(f"Forma vectorial: ({self.x}i, {self.y}j)")

    def obtenerCuadrante(self):
        if(self.x > 0 and self.y > 0):
            return 1
        elif(self.x < 0 and self.y > 0):
            return 2
        elif(self.x < 0 and self.y < 0):
            return 3
        elif(self.x > 0 and self.y < 0):
            return 4
        
    def calcularModulo(self):
        return math.sqrt(math.pow(self.x, 2) + math.pow(self.y, 2))


    def graficarVector(self, cordenadaXInicio, cordenadaYInicio):
        plt.figure()
        plt.axhline(0, color='gray', linewidth=0.5)
        plt.axvline(0, color='gray', linewidth=0.5)
        plt.quiver(cordenadaXInicio, cordenadaYInicio, self.x, self.y, angles='xy', scale_units='xy', scale=1, color='blue')
        plt.xlim(-10, 10)
        plt.ylim(-10, 10)
        plt.grid()
        plt.title("Vector en el plano")
        plt.xlabel("X")
        plt.ylabel("Y")
        plt.gca().set_aspect('equal', adjustable='box')
        plt.show()

def main():

    vector = Vector(2, 2)    
    
    vector.mostrarFormaVectorial()

    modulo = vector.calcularModulo()
    print(f"Módulo del vector: {modulo}")

    cuadrante = vector.obtenerCuadrante()
    print(f"Cuadrante: {cuadrante}")

    vector.graficarVector(0,0)

    input("\nPresiona Enter para salir...")

if __name__ == "__main__":
    main()
