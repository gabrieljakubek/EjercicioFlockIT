# EjercicioFlockIT
La web api fue realizada en la tecnologia .NetCore 3.1 para tener una mayor estabilidad y longevidad del codigo.
Cuenta con dos controladores para cada uno de los ejercicios requerido: 

https://localhost:44367/api/Autorizar

https://localhost:44367/api/Posicion?provincia=

Para la pueba de autorizacion se deben usar el verbo post con el siguiente body en formato JSON:

{
    "user":"FlockIT",
    "password":"FlockIT2022"
}

Para la prueba de posicion se debe usar el verbo get y se puede enviar el nombre de la provincia qué se desea localizar.

Se implemento Swagger para el ambiente de desarrollo.
Cuenta con un Logger y estos mismos se encuentran en la carpeta que contenga a la api si se publica, si se está probando la solucion éstos mismos se encuentran dentro de la carpeta:

\bin\Debug\netcoreapp3.1\logs
