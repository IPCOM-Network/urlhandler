# Como Utilizar este software 

## Parchar regedit 

En el directorio `regedit` encontrara un archivo que al ser ejectuado agrega
un manejador para el protocolo `ipcom`. Esto quiere decir que al enviar al shell
de windows el url `ipcom://abc.com` el shell abrirá el programa indicado en la
linea 14. Nota: los `\` del path deben ser dobles y el `%1` indica el url como
argumento. 

## Consumir API 

Es un simple programa de ejemplo para invocar con el protocolo. Al invocar por 
ejemplo `ipcom://ejemplo.com?id=120` y el llama un GET a `https://ejemplo.com?id=120`
y escribe un pequeño log. 

# Como probar 

Para probar la invocación correctamente presione WIN+R para abrir la ventana de ejecutar. 
Escriba unicamente el url ejemplo: `ipcom://ejemplo.com?id=120`. 
