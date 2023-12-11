import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-perechislenie-хуй-l');
  this.route('i-i-s-perechislenie-хуй-e',
  { path: 'i-i-s-perechislenie-хуй-e/:id' });
  this.route('i-i-s-perechislenie-хуй-e.new',
  { path: 'i-i-s-perechislenie-хуй-e/new' });
});

export default Router;
