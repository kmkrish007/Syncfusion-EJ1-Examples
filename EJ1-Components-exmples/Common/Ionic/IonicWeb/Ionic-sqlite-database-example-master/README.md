# ionic-sqlite-database-example

Creating an Android app with IONIC accessing a database via SQLITE

## Prerequisites (Environment)

- Node.js
- Ionic
- Android SDK (minimum: API level 19)
- Cordova
- Android device or emulator AVD configured

## How to build and run this example (new)

Within the root directory of this project:

Add the Android platform:

    ionic platform add android

To build and run in one shot:

    ionic run android

To build debug APK:

    ionic build android

To install debug APK:

    adb install -r platforms/android/ant-build/CordovaApp-debug.apk

OPTIONAL: To monitor the log statements on the emulator or mobile device:

    adb logcat

## To start with a blank template

### Creating the basic project

IMPORTANT: All commands should be run from the command prompt.

Create an empty Ionic project

    ionic start ionic-sqlite-database-example blank
    cd ionic-sqlite-database-example

Add the cordova-sqlite-storage plugin

    cordova plugin add cordova-sqlite-storage

Include the Android platform in the project

    ionic platform add android

In case you are running on a Mac, you can also include the iOS platform (not addressed here)

    ionic platform add ios

### Customizing the project

Once your project is created, you can setup access to the database using Angular. Edit the following files according to the source of this repository:

- `www/js/app.js` - create the controller, database, create table, insert and select
- `www/index.html` - create the controller call and include the buttons to insert and select

### Build and run in one step

    ionic run android

### Build the app to deploy to Android

Generate the corresponding application .apk:

    ionic build android

### Install on Android emulator or device/smartphone

    adb install -r platforms/android/ant-build/CordovaApp-debug.apk

OPTIONAL:

    adb logcat

## Português (Original com algumas correções)

Criando uma app Android com IONIC acessando banco de dados via SQLITE (ngCordova)

### Pré requisitos (Ambiente)

Ter instalado e configurado as variaveis de ambiente:
(postarei aqui depois como montar o ambiente)
* nodejs
* ionic
* android-sdk (API Level 19)
* cordova
* Ter um dispositivo android ou AVD emulador configurado

Considerando que tudo esta configurado, seguiremos com o tutorial

### Criando o projeto básico

PS: todos os comandos devem ser executados no prompt de comando

Incluir o plugin de acesso a banco de dados SQLite

    cordova plugin add cordova-sqlite-storage

Crie um projeto ionic vazio

    ionic start ionic-sqlite blank
    cd ionic-sqlite

Incluir a plataforma Android ao projeto

    ionic platform add android

Caso esteja rodando em um Mac, pode incluir a plataforma ios tambem (não abordaremos essa plataforma)

    ionic platform add ios

### Customizando o projeto

Ate aqui seu projeto esta criado, vamos agora configurar o acesso ao banco de dados usando AngularJS, edite os seguintes arquivos de acordo com o fonte deste repositorio:
* app.js (criamos aqui o controller, database, create table, insert e select
* index.html (aqui criamos a chamada do controller e incluimos os botoes de inserir e selecionar)

### Deploy do app Android

Vamos gerar o .apk correspondente ao aplicativo

    ionic build android

### Instalar no device/smartphone android

Temos que testar nosso app no nosso celular, basta pluga-lo no usb e ativar o modo de depuração e executar o seguinte comando para instalar no aparelho:

    adb install -r platforms/android/ant-build/CordovaApp-debug.apk

(OPCIONAL) Caso queira monitorar as atividades do celular, inclusive todos os logs que incluimos no Console (codigo do app.j controllers), basta ativar o logcat pelo comando:

    adb logcat

### Pronto, criamos uma aplicação com acesso a banco de dados do zero usando o ionic e fizemos o deploy para o celular android!

Quem quiser dar um fork no projeto e melhorar ele, criando novas funcionalidades, como delete ou update, etc.. fiquem a vontade, vamos deixar esse exemplo o mais completo possivel!

Duvidas podem enviar email para contato@charlesmendes.com

## Créditos (credits)

Esse código foi elaborado com base no tutorial do Nic Raboy (This code was based on the tutorial by Nic Raboy):
https://blog.nraboy.com/2014/11/use-sqlite-instead-local-storage-ionic-framework/

## Support

Support for use of cordova-sqlite-storage and related versions is no longer offered for free. For support enquiries please contact: <sales@litehelpers.net>

## License

MIT, see LICENSE.
