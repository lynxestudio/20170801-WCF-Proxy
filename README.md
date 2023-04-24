# (Windows Communication Foundation): Construir el proxy de manera programática

WCF es el marco de desarrollo de aplicaciones que agrupa las tecnologías distribuidas de Microsoft para la construcción de aplicaciones orientadas a servicios.

Fig 1 WCF agrupa las tecnologías distribuidas de MS en un solo marco de trabajo



WCF ayuda a construir aplicaciones orientadas a servicios de forma práctica

Proporciona herramientas para la creación, el consumo y la puesta en operación de los servicios.
Todas las funcionalidades son administradas por el runtime
No es necesario aprender o conocer a profundidad WSDL.
La arquitectura de WCF puede resumirse en el siguiente esquema.
Fig 2 Una vista general de la arquitectura de WCF



En este esquema se muestra los siguientes pasos de comunicación:

Los clientes utilizan un objeto proxy para enviar mensajes al servicio. Este proxy se encarga de todo el mecanismo de comunicación y funciona como si fuera un objeto local.
Los clientes envían mensajes y reciben respuestas mediante el uso de un Endpoint que los conecta con el servicio.
Un servicio WCF utiliza un dispatcher para convertir el mensaje de petición en la invocación de un método en el servicio.
Los servicios escuchan por los mensajes en uno o más Endpoints.
La estructura de un servicio WCF: El contrato y la implementación
Para ejemplificar cada uno de los componentes de la estructura estándar de un servicio WCF escribí un servicio conversor de temperaturas para convertir entre las diferentes escalas de temperatura: Celsius, Kelvin, Fahrenheit. Este servicio WCF conversor de temperaturas tiene los siguientes elementos:

1.Un contrato para el servicio: qué es la interfaz que define las operaciones y como es el proceso de comunicación para el intercambio de mensajes. Este contrato contiene los siguientes elementos:

a) La referencia al ensamblado System.ServiceModel, este ensamblado proporciona los objetos necesarios para construir los servicios WCF.
b) Una interfaz con el atributo ServiceContract que identifica a la interfaz que el servicio implementará.
c) El atributo OperationContract para identificar cada uno de los métodos que el servicio expondrá.
Fig 3 Código del contrato (Service Contract) para el servicio convertidor de temperatura.



2. La implementación del servicio: Es la clase que implementará la interfaz Service Contract, esta clase utilizará los componentes del .NET Framework con unos atributos WCF opcionales para controlar las características del servicio tales como el tiempo de vida y las sesiones.

Fig 4 Código de la clase de implementación de servicio (Service class)



Ambos archivos, (el contrato IGradeConverter y la implementación GradeConverterImplementation) deben compilarse como biblioteca :NET con el siguiente comando.

$ mcs /t:library -pkg:wcf IGradeConverter.cs GradeConverterImplementation.cs 
/out:Examples.WCFGradeConverter.Service.dll
El proceso huesped (Self-hosted application)
3. Un proceso huésped: Este proceso huésped debe proporcionar el ambiente de ejecución para un servicio WCF. Para hospedad un servicio WCF existen 3 opciones principales:

Self hosted managed application
IIS
WAS
En este ejemplo utilizaré la opción Self hosted managed application.

Fig 5 Código del programa huésped WCF (Self-hosted).



Este proceso huésped requiere información de configuración, por lo que esta información se proporciona en un archivo de configuración.

Fig 6 El archivo App config del proceso huesped.



Para compilar el proceso huésped utilizamos los siguientes comandos:

 $ mcs -r:Examples.WCFGradeConverter.Service.dll -pkg:wcf GradeConverterHost.cs 
 
Construyendo el programa cliente GTK# temperature converter.
Para consumir el servicio WCF, escribí un proyecto cliente GTK# en Monodevelop que invoca las operaciones del servicio, en la siguiente imagen se puede ver la GUI del programa cliente.

Fig 7 El aspecto final del convertidor de temperaturas.



Fig 8 El proyecto y la GUI del convertidor de temperaturas GTK# en MonoDevelop



Hay dos maneras para que un cliente consuma un servicio WCF:

Puedes generar un objeto proxy manualmente, utilizando la herramienta: svcutil desde la línea de comandos.
Puedes usar la clase ChannelFactory para crear un proxy de manera programática.
Fig 9 Utilizando la clase Channel para crear un proxy



Para probar el ejemplo, primero hay que iniciar el proceso host.

Fig 10 Ejecutando el proceso host



Como último paso abrimos el proyecto cliente GTK# y lo ejecutamos desde Mono Develop

Fig 11 Ejecutando el programa desde Monodevelop y convirtiendo 100 grados celsius.



Fig 12 Ejecutando el programa y convirtiendo 451 grados farehnheit.



Descarga el código fuente del servicio WCF
Descarga el código fuente del Self-hosted process
Descarga el código fuente del proyecto Cliente GTK#
