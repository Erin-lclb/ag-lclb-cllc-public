import { Injectable } from '@angular/core';
import { Http, Headers, Response } from "@angular/http";
import { AdoxioLegalEntity } from "../models/adoxio-legalentities.model";
import { Observable } from 'rxjs/Observable';

@Injectable()
export class AdoxioLegalEntityDataService {
   constructor(private http: Http) { }

  /**
   * Get legal entities from Dynamics filtered by position
   * @param positionType
   */
  getLegalEntitiesbyPosition(parentLegalEntityId, positionType: string) {

    let apiPath = `api/adoxiolegalentity/position/${parentLegalEntityId}/${positionType}`;
    let headers = new Headers();
    headers.append("Content-Type", "application/json");

    // call API
    return this.http.get(apiPath, {headers: headers});
  }

  getBusinessProfileSummary() {
    let apiPath = "api/adoxiolegalentity/business-profile-summary/";
    let headers = new Headers();
    headers.append("Content-Type", "application/json");

    // call API
    return this.http.get(apiPath, { headers: headers });

  }

  /**
   * Create a new legal entity in Dynamics
   * @param data - legal entity data
   */
  createLegalEntity(data: any) {
    let headers = new Headers();
    headers.append("Content-Type", "application/json");
    return this.http.post("api/adoxiolegalentity/", data, { headers: headers });
  }

  /**
   * update a  legal entity in Dynamics
   * @param data - legal entity data
   */
  updateLegalEntity(data: any, id: string) {
    let headers = new Headers();
    headers.append("Content-Type", "application/json");
    return this.http.put(`api/adoxiolegalentity/${id}`, data, { headers: headers });
  }

  /**
   * delete a  legal entity in Dynamics
   * @param data - legal entity data
   */
  deleteLegalEntity(id: string) {
    let headers = new Headers();
    headers.append("Content-Type", "application/json");
    return this.http.post(`api/adoxiolegalentity/${id}/delete`,{}, { headers: headers });
  }


  /**
   * Create a new legal entity in Dynamics
   * @param data - legal entity data
   */
  createChildLegalEntity(data: any) {
    let headers = new Headers();
    headers.append("Content-Type", "application/json");
    return this.http.post("api/adoxiolegalentity/child-legal-entity", data, { headers: headers });
  }

  /**
   * Send a consent request to the emails received as parameter
   * @param data - array of emails
   */
  sendConsentRequestEmail(data: string[]) {
    let headers = new Headers();
    headers.append("Content-Type", "application/json");
    let legalEntityId:string = data[0];
    let apiPath = "api/adoxiolegalentity/" + legalEntityId + "/sendconsentrequests";

    return this.http.post(apiPath, data, { headers: headers });
  }

  /**
   * Handle error
   * @param error
   */
  private handleError(error: Response | any) {
     let errMsg: string;
     if (error instanceof Response) {
       const body = error.json() || "";
       const err = body.error || JSON.stringify(body);
       errMsg = `${error.status} - ${error.statusText || ""} ${err}`;
     } else {
       errMsg = error.message ? error.message : error.toString();
     }
     console.error(errMsg);
     return Promise.reject(errMsg);
   }
}
