use ivss;
UPDATE `usuarios` SET clave=AES_ENCRYPT('1234','80865062812') WHERE nombre_usuario like '%ADMIN%'
--el 8086506 es la llave no cambiarlo