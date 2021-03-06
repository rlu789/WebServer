import { Injectable } from '@angular/core';
import { DomService } from './dom.service';

@Injectable()
export class ModalService {

  constructor(private domService: DomService) { }

  private modalElementId = 'modal-container';
  private overlayElementId = 'overlay';

  init(component: any, inputs: object, outputs: object) {
    let componentConfig = {
      inputs:inputs,
      outputs:outputs
    }
    this.domService.appendComponentTo(this.modalElementId, component, componentConfig);
    document.getElementById(this.modalElementId).className = 'custom-modal-show';
    document.getElementById(this.overlayElementId).className = 'custom-modal-show';
    document.getElementsByTagName("body")[0].style['overflow'] = 'hidden';
  }

  destroy() {
    this.domService.removeComponent();
    document.getElementById(this.modalElementId).className = 'custom-modal-hidden';
    document.getElementById(this.overlayElementId).className = 'custom-modal-hidden';
    document.getElementsByTagName("body")[0].style['overflow'] = 'initial';
  }
}