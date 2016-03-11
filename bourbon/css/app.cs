/*
Error: Invalid CSS after "$serif": expected selector or at-rule, was ": $georgia"
        on line 7 of 0-plugins/base/_variables.scss
        from line 6 of 0-plugins/base/_base.scss
        from line 5 of 0-plugins/plugins-dir.sass
        from line 1 of app.sass

2: $medium-screen: 600px;
3: $large-screen: 900px;
4: 
5: // Typography
6: $sans-serif: $monospace
7: $serif: $georgia
8: 
9: $base-font-family: $font-stack-system;
10: $heading-font-family: $base-font-family;
11: 
12: // Font Sizes

Backtrace:
0-plugins/base/_variables.scss:7
0-plugins/base/_base.scss:6
0-plugins/plugins-dir.sass:5
app.sass:1
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/scss/parser.rb:1179:in `expected'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/scss/parser.rb:1115:in `expected'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/scss/parser.rb:40:in `parse'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/engine.rb:403:in `_to_tree'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/engine.rb:309:in `to_tree'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:324:in `block in visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:88:in `block in with_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:115:in `with_frame'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:88:in `with_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:323:in `visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:36:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:158:in `block in visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:79:in `block in with_base'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:115:in `with_frame'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:79:in `with_base'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:158:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:326:in `block (2 levels) in visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:326:in `map'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:326:in `block in visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:88:in `block in with_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:115:in `with_frame'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:88:in `with_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:323:in `visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:36:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:158:in `block in visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:79:in `block in with_base'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:115:in `with_frame'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:79:in `with_base'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:158:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:326:in `block (2 levels) in visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:326:in `map'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:326:in `block in visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:88:in `block in with_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:115:in `with_frame'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:88:in `with_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:323:in `visit_import'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:36:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:158:in `block in visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:79:in `block in with_base'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:115:in `with_frame'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/stack.rb:79:in `with_base'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:158:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:52:in `block in visit_children'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:52:in `map'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:52:in `visit_children'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:167:in `block in visit_children'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:179:in `with_environment'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:166:in `visit_children'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:36:in `block in visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:186:in `visit_root'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/base.rb:36:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:157:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/visitors/perform.rb:8:in `visit'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/root_node.rb:36:in `css_tree'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/tree/root_node.rb:29:in `render_with_sourcemap'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/engine.rb:378:in `_render_with_sourcemap'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/engine.rb:295:in `render_with_sourcemap'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/plugin/compiler.rb:490:in `update_stylesheet'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/plugin/compiler.rb:215:in `block in update_stylesheets'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/plugin/compiler.rb:209:in `each'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/plugin/compiler.rb:209:in `update_stylesheets'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/plugin/compiler.rb:471:in `on_file_changed'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/lib/sass/plugin/compiler.rb:328:in `block in watch'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/vendor/listen/lib/listen/listener.rb:252:in `call'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/vendor/listen/lib/listen/listener.rb:252:in `on_change'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/vendor/listen/lib/listen/listener.rb:290:in `block in initialize_adapter'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/vendor/listen/lib/listen/adapters/polling.rb:48:in `call'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/vendor/listen/lib/listen/adapters/polling.rb:48:in `poll_changed_directories'
C:/RailsInstaller/Ruby2.2.0/lib/ruby/gems/2.2.0/gems/sass-3.4.21/vendor/listen/lib/listen/adapter.rb:299:in `block in start_poller'
*/
body:before {
  white-space: pre;
  font-family: monospace;
  content: "Error: Invalid CSS after \"$serif\": expected selector or at-rule, was \": $georgia\"\A         on line 7 of 0-plugins/base/_variables.scss\A         from line 6 of 0-plugins/base/_base.scss\A         from line 5 of 0-plugins/plugins-dir.sass\A         from line 1 of app.sass\A \A 2: $medium-screen: 600px;\A 3: $large-screen: 900px;\A 4: \A 5: // Typography\A 6: $sans-serif: $monospace\A 7: $serif: $georgia\A 8: \A 9: $base-font-family: $font-stack-system;\A 10: $heading-font-family: $base-font-family;\A 11: \A 12: // Font Sizes"; }
