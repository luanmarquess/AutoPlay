module.exports = function(grunt) {
  require('jit-grunt')(grunt);

  grunt.initConfig({
    less: {
      development: {
        files: {
          "css/estilos.css": "css/estilos.less"  // Caminho dos arquivos
          //endereço arquivo que será compilado : endereço do arquivo .less
        }
      }
    },
    watch: {
      styles: {
        files: ['**/*.less'], // Quais arquivos o grunt ficará de olho
        // ** == todas as pastas; * qualquer arquivo.less
        tasks: ['less']
      }
    }
  });

  grunt.registerTask('default', ['less', 'watch']);
};