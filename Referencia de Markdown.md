# Guía de Markdown

Una referencia completa pero sencilla para escribir archivos Markdown (`.md`).

---

## 1. Encabezados

Usa símbolos `#` al inicio de una línea.

```md
# Encabezado 1
## Encabezado 2
### Encabezado 3
#### Encabezado 4
##### Encabezado 5
###### Encabezado 6
```

Usa un solo `#` para el título principal del documento y encabezados menores para las secciones.

---

## 2. Párrafos

Escribe texto normal y deja una línea en blanco entre párrafos.

```md
Este es el primer párrafo.

Este es el segundo párrafo.
```

---

## 3. Negrita, cursiva y tachado

```md
**Texto en negrita**

*Texto en cursiva*

***Negrita y cursiva***

~~Texto tachado~~
```

Resultado:

**Texto en negrita**

*Texto en cursiva*

***Negrita y cursiva***

~~Texto tachado~~

---

## 4. Listas sin numerar

Usa `-`, `*` o `+`.

```md
- Elemento uno
- Elemento dos
- Elemento tres
```

Para crear sublistas, usa sangría:

```md
- Elemento principal
  - Sub-elemento
  - Otro sub-elemento
- Segundo elemento principal
```

---

## 5. Listas numeradas

Usa números seguidos de un punto.

```md
1. Primer paso
2. Segundo paso
3. Tercer paso
```

También puedes escribir:

```md
1. Primero
1. Segundo
1. Tercero
```

La mayoría de los visores de Markdown los numerarán automáticamente.

---

## 6. Listas de tareas

```md
- [x] Tarea completada
- [ ] Tarea pendiente
- [ ] Otra tarea
```

Son útiles para planes de proyecto, notas y tareas en GitHub.

---

## 7. Enlaces

Enlace básico:

```md
[OpenAI](https://openai.com)
```

Enlace con título:

```md
[OpenAI](https://openai.com "Visitar OpenAI")
```

Enlace automático:

```md
<https://openai.com>
```

---

## 8. Imágenes

```md
![Texto alternativo](ruta-o-url-de-la-imagen.png)
```

Ejemplo:

```md
![Logotipo](imagenes/logo.png)
```

El texto alternativo mejora la accesibilidad y aparece si la imagen no puede cargarse.

---

## 9. Citas en bloque

Usa `>`:

```md
> Esta es una cita.
```

Cita anidada:

```md
> Cita principal
>
> > Cita anidada
```

---

## 10. Código en línea

Encierra código corto, comandos, nombres de archivos o términos técnicos entre acentos graves.

```md
Usa la función `print()`.
```

Resultado:

Usa la función `print()`.

---

## 11. Bloques de código

Usa tres acentos graves antes y después del código.

````md
```text
Tu código va aquí.
```
````

Añade el nombre del lenguaje para obtener resaltado de sintaxis:

````md
```python
def saludar():
    print("Hola, mundo")
```
````

Algunas etiquetas comunes son:

- `python`
- `javascript`
- `typescript`
- `html`
- `css`
- `json`
- `bash`
- `sql`
- `yaml`
- `markdown`
- `text`

---

## 12. Líneas horizontales

Usa tres o más guiones, asteriscos o guiones bajos.

```md
---
```

También puedes usar:

```md
***
```

---

## 13. Tablas

```md
| Nombre | Rol         | Estado |
|--------|-------------|--------|
| Ana    | Diseñadora  | Activa |
| Luis   | Desarrollador | Activo |
```

Alineación:

```md
| Izquierda | Centro | Derecha |
|:----------|:------:|--------:|
| A         | B      | C       |
```

- `:---` = alineado a la izquierda
- `:---:` = centrado
- `---:` = alineado a la derecha

---

## 14. Escapar caracteres especiales

Usa una barra invertida `\` antes de un carácter especial cuando quieras mostrarlo literalmente.

```md
\*Esto no está en cursiva\*
\# Esto no es un encabezado
```

Caracteres que a veces conviene escapar:

```text
\ ` * _ { } [ ] < > ( ) # + - . ! |
```

---

## 15. Saltos de línea

La forma más segura de crear un nuevo párrafo es dejar una línea en blanco.

```md
Primer párrafo.

Segundo párrafo.
```

Algunos procesadores de Markdown también permiten añadir dos espacios al final de una línea para forzar un salto:

```md
Primera línea.  
Segunda línea.
```

---

## 16. Formato combinado

Los estilos de Markdown pueden combinarse.

```md
**Este texto contiene *cursiva* dentro de negrita.**
```

También puedes aplicar formato dentro de enlaces:

```md
[**Enlace en negrita**](https://example.com)
```

---

## 17. HTML dentro de Markdown

Muchos procesadores de Markdown permiten usar HTML básico.

```html
<details>
  <summary>Haz clic para expandir</summary>

  El contenido oculto va aquí.

</details>
```

La compatibilidad depende de la plataforma, así que conviene usar HTML solo cuando sea necesario.

---

## 18. Notas al pie

Algunas variantes de Markdown permiten notas al pie.

```md
Aquí hay una afirmación con una nota.[^1]

[^1]: Este es el texto de la nota al pie.
```

No todos los visores de Markdown las admiten.

---

## 19. Listas de definiciones

Algunas variantes extendidas de Markdown permiten listas de definiciones.

```md
Markdown
: Un lenguaje de marcado ligero.

HTML
: Un lenguaje de marcado para páginas web.
```

Esta función no forma parte del Markdown básico y puede no funcionar en todas partes.

---

## 20. Enlaces a encabezados

Muchas plataformas crean automáticamente identificadores para los encabezados.

Por ejemplo:

```md
## Guía de instalación
```

Puede enlazarse así:

```md
[Ir a la Guía de instalación](#guía-de-instalación)
```

Las reglas exactas para generar los enlaces internos pueden variar según la plataforma.

---

## 21. Enlaces relativos

Puedes enlazar archivos dentro del mismo proyecto.

```md
[Leer la guía de configuración](docs/configuracion.md)
```

Para subir un nivel de carpeta:

```md
[Volver al README](../README.md)
```

---

## 22. Imágenes relativas

```md
![Diagrama](recursos/diagrama.png)
```

Esto es útil en repositorios de GitHub y proyectos de documentación.

---

## 23. Comentarios

Markdown no define comentarios de forma nativa, pero normalmente puedes usar comentarios HTML.

```html
<!-- Este comentario no aparecerá en el documento renderizado. -->
```

---

## 24. Markdown de GitHub

GitHub admite varias extensiones muy útiles.

### Listas de tareas

```md
- [x] Crear repositorio
- [ ] Escribir documentación
```

### Tablas

```md
| Función | Terminada |
|---------|-----------|
| Inicio de sesión | Sí |
```

### Tachado

```md
~~Información antigua~~
```

### Enlaces automáticos

```md
https://github.com
```

GitHub puede convertir automáticamente esta URL en un enlace.

---

## 25. Ejemplo de estructura para un README

Un archivo `README.md` sencillo puede verse así:

````md
# Nombre del proyecto

Descripción breve del proyecto.

## Características

- Característica uno
- Característica dos
- Característica tres

## Instalación

```bash
git clone https://github.com/ejemplo/proyecto.git
cd proyecto
```

## Uso

Explica cómo utilizar el proyecto.

## Configuración

Describe los ajustes importantes.

## Contribuir

Explica cómo pueden colaborar otras personas.

## Licencia

Indica la licencia del proyecto.
````

---

## 26. Ejemplo de página de documentación

```md
# Primeros pasos

Esta guía explica cómo configurar la aplicación.

## Requisitos

- Python 3
- Git
- Conexión a Internet

## Instalación

1. Clona el repositorio.
2. Instala las dependencias.
3. Inicia la aplicación.

## Configuración

Edita `config.json` y añade tus ajustes.

## Solución de problemas

### La aplicación no inicia

Comprueba que todas las dependencias necesarias estén instaladas.

### No se detecta la configuración

Verifica que `config.json` esté en la carpeta correcta.
```

---

## 27. Buenas prácticas de Markdown

### Usa una jerarquía clara de encabezados

Recomendado:

```md
# Título del documento

## Sección principal

### Subsección
```

Evita saltar sin motivo entre niveles de encabezado.

### Mantén los párrafos legibles

Los párrafos cortos suelen ser más fáciles de leer que los bloques de texto muy largos.

### Usa formato de código para elementos técnicos

Ejemplos:

```md
Ejecuta `npm install`.

Abre `config.json`.

Cambia `debug` a `true`.
```

### Usa textos descriptivos para los enlaces

Mejor:

```md
[Leer la guía de instalación](instalacion.md)
```

En lugar de:

```md
[Haz clic aquí](instalacion.md)
```

### Añade descripciones útiles a las imágenes

Mejor:

```md
![Panel mostrando los ingresos mensuales](panel.png)
```

En lugar de:

```md
![Imagen](panel.png)
```

### Deja líneas en blanco alrededor de elementos importantes

Esto mejora la compatibilidad entre distintos procesadores de Markdown.

---

## 28. Archivos Markdown comunes

Markdown suele utilizarse en archivos como:

```text
README.md
CONTRIBUTING.md
CHANGELOG.md
LICENSE.md
documentacion.md
notas.md
guia.md
```

La extensión `.md` indica que el archivo contiene Markdown.

---

## 29. Compatibilidad de Markdown

No todas las aplicaciones admiten exactamente la misma sintaxis.

Algunas variantes comunes son:

- CommonMark
- GitHub-Flavored Markdown (GFM)
- Markdown Extra
- MultiMarkdown

Las funciones básicas, como encabezados, énfasis, enlaces, listas, citas y bloques de código, tienen una compatibilidad muy amplia.

Funciones extendidas como tablas, notas al pie, listas de tareas y listas de definiciones dependen del procesador.

---

## 30. Referencia rápida

| Objetivo | Markdown |
|---|---|
| Encabezado 1 | `# Encabezado` |
| Encabezado 2 | `## Encabezado` |
| Negrita | `**texto**` |
| Cursiva | `*texto*` |
| Negrita + cursiva | `***texto***` |
| Tachado | `~~texto~~` |
| Enlace | `[texto](https://example.com)` |
| Imagen | `![alt](imagen.png)` |
| Código en línea | `` `código` `` |
| Cita | `> cita` |
| Viñeta | `- elemento` |
| Elemento numerado | `1. elemento` |
| Tarea | `- [ ] tarea` |
| Línea horizontal | `---` |

---

# Plantilla inicial de Markdown

Puedes copiar esta plantilla al comenzar un nuevo documento:

````md
# Título del documento

Introducción breve.

## Resumen

Explica el propósito del documento.

## Sección principal

Escribe aquí el contenido principal.

### Subsección

Añade detalles adicionales.

## Ejemplo

```text
Contenido de ejemplo
```

## Notas

- Punto importante
- Otro punto

## Recursos

- [Nombre del recurso](https://example.com)
````

---

# Consejo final

Markdown está diseñado para ser legible incluso antes de renderizarse.

Cuando tengas dudas, prioriza:

1. Encabezados claros
2. Párrafos cortos
3. Listas sencillas
4. Enlaces descriptivos
5. Formato consistente

Con eso es suficiente para la mayoría de los documentos Markdown.
