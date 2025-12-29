# Mi primer programa: Validar contraseña
# Autor: Diego Orellana
contrasena_secreta = "Ingeniero2026"
intento_usuario = ""

print("--- SISTEMA DE SEGURIDAD ---")

# Mientras la contraseña sea incorrecta, seguimos preguntando
while intento_usuario != contrasena_secreta:
    intento_usuario = input("Ingrese la contraseña: ")
    
    if intento_usuario != contrasena_secreta:
        print("Acceso denegado. Intente de nuevo.")

print("¡Acceso Concedido! Bienvenido al sistema.")
